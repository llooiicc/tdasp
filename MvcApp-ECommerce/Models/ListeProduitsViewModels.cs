using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting.Internal;
using MvcApp.Models;
using MvcAppECommerce.Models;

namespace ECommerce.Models
{
    public class ListeProduitsViewModels
    {
        public IQueryable<Produit> listProduits { get; }
        
        
        public ListeProduitsViewModels(IQueryable<Produit> listProduits)
        {

            PaginationInfos.nbrPages = (int) Math.Ceiling((double)(listProduits.Count() / PaginationInfos.ProduitsParPage));
            int start = 0;
            int stop = PaginationInfos.ProduitsParPage;
            if (PaginationInfos.PageCourante == 1)
            {
                start = 0;
            }
            else
            {
                start = PaginationInfos.PageCourante * PaginationInfos.ProduitsParPage - (PaginationInfos.ProduitsParPage);
            }

            this.listProduits = listProduits.Skip(start).Take(3);
            
            
            string debug = String.Format(
                "{0}\nstart = {1}\nstop = {2}\npage courante = {3}\n{4}",
                "*********************************************************",
                start , stop , PaginationInfos.PageCourante,
                "*********************************************************");
            
            Console.WriteLine(debug);
               
        }
        
        
        
        
    }
}