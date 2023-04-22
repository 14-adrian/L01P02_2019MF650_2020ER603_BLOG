using Microsoft.EntityFrameworkCore;
namespace L01P02_2019MF650_2020ER603_BLOG.Models
{
    public class blogContext : DbContext
    {
        public blogContext(DbContextOptions<blogContext> options) : base(options)
        {

        }

        public DbSet<usuarios> usuarios { get; set; }

        public DbSet<publicaciones> publicaciones { get; set; }

        public DbSet<calificaciones> calificaciones { get; set; }

        public DbSet<comentarios> comentarios { get; set; }
    }
}
