using HandleErrorsExample.Controllers.TheFirstException;
using HandleErrorsExample.Interfaces.TheFirstException;
using HandleErrorsExample.Interfaces.TheSecondException;
using HandleErrorsExample.Services.TheFirstException;
using HandleErrorsExample.Services.TheSecondException;
using Microsoft.Extensions.DependencyInjection;

namespace HandleErrorsExample.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddHandleErrorsExampleServices(this IServiceCollection services)
        {
            services.AddScoped<IFirstException, TheFirstExceptionService>();
            services.AddScoped<TheFirstExceptionController>();
            services.AddScoped<ISecondException, TheSecondExceptionService>();
            services.AddScoped<TheFirstExceptionController>();

            return services;
        }
    }
}
