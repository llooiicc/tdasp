using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MvcAppECommerce.Models;
using Remotion.Linq.Clauses;

namespace MvcApp.Models
{
    public class EFProductRepository : IProductRepository
    {
        
        private ApplicationDbContext context;
        
        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Produit> Produit => context.Produits;

    }
}