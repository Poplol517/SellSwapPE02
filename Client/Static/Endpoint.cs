namespace SellSwap.Client.Static
{
    public class Endpoints
    {
        private static readonly string Prefix = "api";
        public static readonly string ListingsEndpoint = $"{Prefix}/listings";
        public static readonly string ListingStatusEndpoint = $"{Prefix}/listingstatus";
        public static readonly string ListingTypeEndpoint = $"{Prefix}/listingtype";
        public static readonly string CategoriesEndpoint = $"{Prefix}/categories";
        public static readonly string UsersEndpoint = $"{Prefix}/users";
    }
}
