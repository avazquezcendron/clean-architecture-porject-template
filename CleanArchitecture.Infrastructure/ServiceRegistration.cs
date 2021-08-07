using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Application.Contracts.Services;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Infrastructure.Persistence.Contexts;
using CleanArchitecture.Infrastructure.Persistence.Repositories;
using CleanArchitecture.Infrastructure.Persistence.Services;
using AutoMapper;
using System.Reflection;
using CleanArchitecture.Application.Mappings;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("Default"),
                   b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            }

            #region Repositories
            //services.AddTransient(typeof(IGenericRepositoryAsync), typeof(GenericRepositoryAsync));
            services.AddTransient<IStoryRepositoryAsync, StoryRepositoryAsync>();
            services.AddTransient<ITagRepositoryAsync, TagRepositoryAsync>();
            services.AddTransient<IUserRepositoryAsync, UserRepositoryAsync>();
            #endregion

            #region Services
            services.AddAutoMapper(typeof(Profiles));
            //Mapper.AssertConfigurationIsValid();
            services.AddTransient<IStoryService>(provider => new StoryService(provider.GetService<IMapper>(), provider.GetService<IStoryRepositoryAsync>(), provider.GetService<ITagRepositoryAsync>()));
            services.AddTransient<ITagService>(provider => new TagService(provider.GetService<IMapper>(), provider.GetService<ITagRepositoryAsync>()));
            services.AddTransient<IUserService>(provider => new UserService(provider.GetService<IMapper>(), provider.GetService<IUserRepositoryAsync>()));

            #endregion
        }
    }
}
