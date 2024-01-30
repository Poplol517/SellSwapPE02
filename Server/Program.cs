using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using SellSwap.Server.Data;
using SellSwap.Server.Models;
using Microsoft.AspNetCore.Identity;
using SellSwap.Server.IRepository;
using SellSwap.Server.Repository;
using AutoMapper.Internal.Mappers;
using SellSwap.Server.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentityServer()
    .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

builder.Services.AddAuthentication()
    .AddIdentityServerJwt();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
builder.Services.AddResponseCompression(options =>
    options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] {"application/octet-stream"}));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();
app.UseResponseCompression();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();
app.UseAuthorization();


app.MapRazorPages();
app.MapControllers();
app.MapHub<ChatHub>("/chathub");
app.MapFallbackToFile("index.html");


//Creating Staff whenever the program runs
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

    var roles = new[] { "Staff", "User" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
            await roleManager.CreateAsync(new IdentityRole(role));
    }

    string email = "staff@staff.com";
    string password = "Test1234!";


    var user = await userManager.FindByEmailAsync(email);

    if (user == null)
    {
        user = new ApplicationUser
        {
            UserName = email,
            Email = email
        };

        await userManager.CreateAsync(user, password);
    }

    // Check if the user is already in the "Staff" role
    if (!await userManager.IsInRoleAsync(user, "Staff"))
    {
        // Assign the user to the "Staff" role
        await userManager.AddToRoleAsync(user, "Staff");
    }
}



app.Run();
