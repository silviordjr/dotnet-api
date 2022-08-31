using Microsoft.EntityFrameworkCore;
using usuario.Model;

namespace usuario.Data
{
    public class UsuarioDB : DbContext
    {
        public UsuarioDB(DbContextOptions<UsuarioDB> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios {get; set;}
    }
}