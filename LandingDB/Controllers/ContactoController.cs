using LandingDB.UseCase.Contactos.GetAll;
using Microsoft.AspNetCore.Mvc;

namespace LandingDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactoController: ControllerBase
    {
        private readonly IGetAllUC _getAllUC;

        public ContactoController(IGetAllUC getAllUC)
        {
            _getAllUC = getAllUC;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contactos = await _getAllUC.Execute();
            return Ok(contactos);
        }
    }
}
