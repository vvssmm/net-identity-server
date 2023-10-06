namespace NET.OpenIddict.Extensions
{
    public static class OpenIdDictServiceExtension
    {
        public static void AddOpenIddict(this IServiceCollection services)
        {
            services.AddControllersWithViews();
            //services.AddDbContext<ApplicationDbContext>(options =>
            //{
            //    // Configure Entity Framework Core to use Microsoft SQL Server.
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            //    // Register the entity sets needed by OpenIddict.
            //    // Note: use the generic overload if you need to replace the default OpenIddict entities.
            //    options.UseOpenIddict();
            //});
        }
    }
}
