using Microsoft.Extensions.DependencyInjection;
using System;
using Template.Application.Services;
using Template.Application.Interfaces;
using Template.Domain.Interfaces;
using Template.Data.Repositories;

namespace Template.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion

        }
    }
}
