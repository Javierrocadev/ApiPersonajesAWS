using ApiPersonajesAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPersonajesAWS.Data
{
    public class PersonajesContext : DbContext
    {
        public PersonajesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Personaje> Personajes { get; set; }
    }
}
