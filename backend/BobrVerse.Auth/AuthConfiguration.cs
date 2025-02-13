﻿using BobrVerse.Auth.Context;
using BobrVerse.Auth.Interfaces;
using BobrVerse.Auth.Models.Settings;
using BobrVerse.Auth.Services;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace BobrVerse.Auth
{
    public static class AuthConfiguration
    {
        public static IServiceCollection AddAuth(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddScoped<IAuthService, CookieAuthService>();
            services.AddScoped<IAccessTokenService, AccessTokenService>();
            services.AddScoped<IRefreshTokenService, RefreshTokenService>();
            services.AddScoped<IEmailPasswordAuthService, EmailPasswordAuthService>();
            services.AddScoped<IGoogleAuthService, GoogleAuthService>();
            services.AddScoped<IUserContextService, UserContextService>();
            services.AddSingleton<IConnectionMultiplexer>(x =>
            {
                var settings = x.GetRequiredService<AuthSettings>();
                return ConnectionMultiplexer.Connect(settings.Redis.ConnectionString);
            });
            services.AddScoped<IRefreshTokenStore, RedisRefreshTokenStore>();

            return services;
        }
        public static void AddAuthDbContext<T>(this IServiceCollection services) where T : class, IAuthContext
        {
            services.AddScoped<IAuthContext, T>();
        }
    }
}
