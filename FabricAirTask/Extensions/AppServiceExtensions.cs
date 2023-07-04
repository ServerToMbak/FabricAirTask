using FabricAirTask.Data.Abstract;
using FabricAirTask.Data.Concrete;
using FabricAirTask.Services.Abstract;
using FabricAirTask.Services.Concrete;

namespace FabricAirTask.Extensions
{
    public static class AppServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddScoped<IFileRepo, FileRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();


            return services;
        }
    }
}
