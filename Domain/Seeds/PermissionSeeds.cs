namespace Domain.Seeds {
    public static class PermissionSeeds {
        // Read & Write & Update & Delete Permissions

        public const string IsRegistered = "IsRegistered";
        public const string IsSuperAdmin = "IsSuperAdmin";

        public const string CanReadBorrowers = "CanReadBorrowers";
        public const string CanReadOwnBorrowers = "CanReadOwnBorrowers";
        public const string CanAddBorrower = "CanAddBorrower";
        public const string CanUpdateBorrower = "CanUpdateBorrower";
        public const string CanDeleteBorrower = "CanDeleteBorrower";

        public const string CanReadApplications = "CanReadApplications";
        public const string CanReadOwnApplications = "CanReadOwnApplications";
        public const string CanAddApplication = "CanAddApplication";
        public const string CanUpdateApplication = "CanUpdateApplication";
        public const string CanDeleteApplication = "CanDeleteApplication";

        public const string CanGenerateMatrix = "CanGenerateMatrix";
        public const string CanUploadMatrix = "CanUploadMatrix";

        public const string CanAddLoan = "CanAddLoan";
        public const string CanDeleteLoan = "CanDeleteLoan";
        public const string CanUpdateLoan = "CanUpdateLoan";
    }
}
