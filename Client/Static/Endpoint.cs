namespace SellSwap.Client.Static
{
    public class Endpoints
    {
        private static readonly string Prefix = "api";
        public static readonly string ListingsEndpoint = $"{Prefix}/listings";
        public static readonly string ListingStatusEndpoint = $"{Prefix}/listingstatus";
        public static readonly string ListingTypeEndpoint = $"{Prefix}/listingtype";
        public static readonly string ConditionTypeEndpoint = $"{Prefix}/conditiontypes";
        public static readonly string CategoriesEndpoint = $"{Prefix}/categories";
        public static readonly string OffersEndpoint = $"{Prefix}/offers";
        public static readonly string UsersEndpoint = $"{Prefix}/users";
        public static readonly string AccountsEndpoint = $"{Prefix}/accounts";
    }
}
