using System;
using System.Collections.Generic;
using System.Linq;
using ECommerce.Models;
using MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using MvcAppECommerce.Models;

namespace MvcApp.Controllers
{
    public class ProduitsController : Controller
    {

        public IProductRepository repos { get; }
        
        
        public ProduitsController(IProductRepository r)
        {
            repos = r;
            
        }
        
        public ActionResult List(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
               
                PaginationInfos.PageCourante = 1;
                ViewBag.pageCourante = 1;
                ViewBag.produits = new ListeProduitsViewModels(repos.Produit).listProduits;
                ViewBag.nbrPages = PaginationInfos.nbrPages;
                return View();
            }
            
            else
            {
                int pageCourente = int.Parse(id);
                PaginationInfos.PageCourante = pageCourente;
                ViewBag.pageCourante = pageCourente;
                ViewBag.produits = new ListeProduitsViewModels(repos.Produit).listProduits;
                ViewBag.nbrPages = PaginationInfos.nbrPages;
                return View();
            }
        }

        
    }
}