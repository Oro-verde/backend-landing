using LandingDB.Services;

namespace LandingDB.Data.DependencyInjection
{
    public class IoC
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // SERVICIOS
            services.AddTransient<IContactoService, ContactoService>();

            // USE CASES
            services.AddTransient<UseCase.Contactos.GetAll.IGetAllUC, UseCase.Contactos.GetAll.GetAllUC>();
        }
    }
}
