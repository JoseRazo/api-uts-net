using Microsoft.EntityFrameworkCore;

namespace ApiUtsNet.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }


    // Aqui van todos los modelos
        public DbSet<Pais> Paises { get; set; }
    }
}