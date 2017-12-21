using System.Linq;

namespace MvcApp.Models
{
    public interface IProductRepository
    {
        IQueryable<Produit> Produit { get; }
  
    }
}