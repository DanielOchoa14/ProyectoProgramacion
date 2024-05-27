using Microsoft.EntityFrameworkCore;

namespace Actividad17.Data
{
    public class DirectorioDBContext : DbContext
    {
        public DirectorioDBContext(
            DbContextOptions<DirectorioDBContext> options)
            :base(options)
        {

        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Productos> Productos { get; set; }

       
    }
}
