using Microsoft.EntityFrameworkCore;

namespace AgenciaDeViagens.Models
{
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Contato> Contato { get; set; }


    }
}
