using Microsoft.Extensions.DependencyInjection;
using SpitalPneumo.DataAccess.EntityFramework.Repositories;
using SpitalPneumo.Domain.Repositories;

namespace SpitalPneumo.DataAccess.EntityFramework.Configurations.Ioc
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IAdministrationRepository, AdministrationRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
        }
    }
}
