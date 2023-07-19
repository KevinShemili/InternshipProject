namespace Infrastructure.Persistence.Seeds {
    public static class Permissions {
        // Read & Write & Update & Delete Permissions

        public const string IsRegistered = "IsRegistered";
        public const string IsSuperAdmin = "IsSuperAdmin";

        public const string CanReadBorrowers = "CanReadBorrowers";
        public const string CanAddBorrower = "CanAddBorrower";
        public const string CanUpdateBorrower = "CanUpdateBorrower";
        public const string CanDeleteBorrower = "CanDeleteBorrower";

        public const string CanReadUsers = "CanReadUsers";
        public const string CanAddUser = "CanAddUser";
        public const string CanUpdateUser = "CanUpdateUser";
        public const string CanDeleteUser = "CanDeleteUser";
    }
}
