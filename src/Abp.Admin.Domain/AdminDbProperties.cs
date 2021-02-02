namespace Abp.Admin
{
    public static class AdminDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Admin";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Admin";
    }
}
