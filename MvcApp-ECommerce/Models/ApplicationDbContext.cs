using Microsoft.EntityFrameworkCore;

namespace MvcApp.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
            
        }
        
        
        public DbSet<Produit> Produits { get; set; }
        
    }
}