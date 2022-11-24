using Microsoft.EntityFrameworkCore;
using ProjetoCursoAPI.Models;

namespace ProjetoCursoAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) // está passando o options para a classe base(dbcontext)
        {

        }
        //Mapeando entidades
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
    }
}
