using Microsoft.EntityFrameworkCore;

namespace dbcodefirst 
{
    public class AppDbContext : DbContext
    {
        //mapeamento da entidade para a tabela
        public DbSet<Produto> Produtos {get; set;}

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           optionsBuilder.UseSqlServer("Data Source=MOTA;" + "Initial Catalog=EFCoreDB;Integrated Security=True");
       }
    }
}