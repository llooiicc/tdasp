using System.ComponentModel.DataAnnotations;

namespace MvcApp.Models
{
    public class Produit
    {
        
        private int idProduit;
        private string nom;
        private string description;
        private string categorie;
        private double prix;
        
        public Produit(){}

        [Key]
        public int IdProduit
        {
            get => idProduit;
            set => idProduit = value;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string Categorie
        {
            get => categorie;
            set => categorie = value;
        }

        public double Prix
        {
            get => prix;
            set => prix = value;
        }
    }
}