using ApiPeliculas.Models;
using Microsoft.EntityFrameworkCore;


namespace ApiPeliculas.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)    
        {
            
        }

        //Aqui pasamos los modelos
        public DbSet<Categoria> Categorias { get; set; }    
    }
}
