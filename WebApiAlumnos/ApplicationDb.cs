using Microsoft.EntityFrameworkCore;
using WebApiAlumnos.BD;

namespace WebApiAlumnos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Gatito> Gatitos { get; set; }

    }
}
