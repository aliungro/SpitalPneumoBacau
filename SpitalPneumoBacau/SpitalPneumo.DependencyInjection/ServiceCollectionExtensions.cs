using Microsoft.Extensions.DependencyInjection;
using SpitalPneumo.DataAccess.EntityFramework.Configurations.Ioc;

namespace SpitalPneumo.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddIoc(this IServiceCollection services)
        {
            services.AddDataAccess();
        }
    }
}
