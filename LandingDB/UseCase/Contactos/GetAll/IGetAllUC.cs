using LandingDB.Models;

namespace LandingDB.UseCase.Contactos.GetAll
{
    public interface IGetAllUC
    {
        Task<List<Contacto>> Execute();
    }
}
