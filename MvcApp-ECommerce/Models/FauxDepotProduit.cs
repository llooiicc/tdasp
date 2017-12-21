using System.Collections.Generic;
using System.Linq;

namespace MvcApp.Models
{
    public class FauxDepotProduit : IProductRepository
    {
        public IQueryable<Produit> Produit { get; }
        public IQueryable<Produit> ProduitRange { get; }

        public FauxDepotProduit()
        {
            List<Produit> listProduits = new List<Produit>();
            
            Produit p1 = new Produit();
            p1.IdProduit = 1;
            p1.Nom = "objet 1";
            p1.Description = "objet de type produit";
            p1.Categorie = "categorie A";
            p1.Prix = 100.99;
            listProduits.Add(p1);
            
            Produit p2 = new Produit();
            p2.IdProduit = 2;
            p2.Nom = "objet 2";
            p2.Description = "objet de type produit";
            p2.Categorie = "categorie A";
            p2.Prix = 10.99;
            listProduits.Add(p2);
            
            Produit p3 = new Produit();
            p3.IdProduit = 3;
            p3.Nom = "objet 3";
            p3.Description = "objet de type produit";
            p3.Categorie = "categorie B";
            p3.Prix = 1.99;
            listProduits.Add(p3);
            
            Produit p4 = new Produit();
            p4.IdProduit = 4;
            p4.Nom = "objet 4";
            p4.Description = "objet de type produit";
            p4.Categorie = "categorie B";
            p4.Prix = 9.99;
            listProduits.Add(p4);
            
            Produit p5 = new Produit();
            p5.IdProduit = 5;
            p5.Nom = "objet 5";
            p5.Description = "objet de type produit";
            p5.Categorie = "categorie C";
            p5.Prix = 55.99;
            listProduits.Add(p5);
            
            Produit = new EnumerableQuery<Produit>(listProduits.AsQueryable());
        }
    }
}