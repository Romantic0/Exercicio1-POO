using Exercicio_1.models;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) 
        {    

        
        }

        public DbSet<Cidade> Cidades { get; set; }
    }
}
