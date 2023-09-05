namespace DependencyStore.Extensions
{
    public static class ConfigurationExtension
    {
        public static void AddConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<Configuration>();

        }
    }
}
