namespace WebStore.Core.Constants
{
    public static class AuthorizationConstants
    {
        public const string DEFAULT_PASSWORD = "Password123!";

        public static class Roles
        {
            public const string ADMINISTRATORS = "Administrators";
            public const string MANAGERS = "Managers";
            public const string USERS = "Users";
        }

        public static class Policies
        {
            public const int MINIMUM_ORDER_AGE = 18;
        }
    }
}
