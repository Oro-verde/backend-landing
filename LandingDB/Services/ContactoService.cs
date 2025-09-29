using LandingDB.Data;
using LandingDB.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace LandingDB.Services
{
    public class ContactoService: IContactoService
    {
        private readonly AppDbContext _ctx;

        public ContactoService(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<List<Contacto>> GetAll()
        {
            return await _ctx.Contactos.ToListAsync();
        }

    }

}