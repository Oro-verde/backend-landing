using LandingDB.Models;
using LandingDB.Services;

namespace LandingDB.UseCase.Contactos.GetAll
{
    public class GetAllUC : IGetAllUC
    {
        private readonly IContactoService contactoService;

        public GetAllUC(IContactoService ContactoService )
        {
            contactoService = ContactoService;
        }
        public async Task<List<Contacto>> Execute()
        {
           return await contactoService.GetAll();
        }
    }
}
