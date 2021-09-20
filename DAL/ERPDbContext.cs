using Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DAL
{
    public class ERPDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // adiciona as classes do mapping para o EF que estão no projeto(assembly) que no caso é o DAL
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme\Documents\teste.mdf;Integrated Security=True;Connect Timeout=30",
                                        options => options.EnableRetryOnFailure(5));

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
