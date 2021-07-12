using Like.Application.Interface;
using Like.Application.Services;
using Like.Domain.Interfaces.Repositories;
using Like.Domain.Interfaces.Services;
using Like.Domain.Services;
using Like.Repository.Context;
using Like.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Like.DI
{
    public static class DependencyInjection
    {
        public static void Register(IServiceCollection services)
        {
            RegisterApplication(services);
            RegisterDomain(services);
            RegisterRepository(services);
        }
        public static void RegisterApplication(IServiceCollection services)
        {
            services.AddScoped<IArticleApplication, ArticleApplication>();
        }
        public static void RegisterDomain(IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
        }
        public static void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IArticleHistoryRepository, ArticleHistoryRepository>();
        }
    }
}
