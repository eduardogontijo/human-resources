using Human.Resources.Domain.Core.Filters;
using Human.Resources.Domain.Core.Notification;
using Human.Resources.Domain.Interfaces;
using Human.Resources.Infra.Data.Repository;
using Human.Resources.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Human.Resources.Infra.CrossCutting.IoC
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeService, EmployeeService>();

            services.AddScoped<DomainNotification>();
            services.AddMvc(options => options.Filters.Add<NotificationFilter>())
           .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }
    }
}
