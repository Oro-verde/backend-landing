using LandingDB.Models;

namespace LandingDB.Services
{
    public interface IContactoService
    {
        Task<List<Contacto>> GetAll();
    }
}
