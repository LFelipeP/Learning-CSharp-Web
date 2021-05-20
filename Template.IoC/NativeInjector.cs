using Microsoft.Extensions.DependencyInjection;
using System;
using Template.Application.Services;
using Template.Application.Interfaces;

namespace Template.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IUserService, UserService>();

        }
    }
}
