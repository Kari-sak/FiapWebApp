using Fiap.Web.App.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.App.Data
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto>? Produtos { get; set; }
        public LojaContext(DbContextOptions options) : base(options) { }
    }

}
