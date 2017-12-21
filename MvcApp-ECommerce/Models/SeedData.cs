using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcApp.Models;
using System.Linq;

namespace ECommerce.Models
{
    public static class SeedData
    {
        public static void ProduitsVente(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Produits.Any())
            {
                List<Produit> l = new List<Produit>();
                String[] cat = {"A","B","C","D"};
                for (int i = 99; i < 999; i++)
                {
                    Produit p = new Produit();
                    p.Nom = String.Format("Produit {0}" , i.ToString());
                    p.Description = "description";
                    p.IdProduit = i;
                    p.Prix = new Random().NextDouble() * (1000.0 - 0.01) + 0.01;
                    p.Categorie = cat[new Random().Next(0, 3)];
                    
                    l.Add(p);
                    Console.WriteLine(p);
                    
                }
                foreach (Produit p in l)
                {
                    context.Produits.Add(p);
                }
                
                context.SaveChanges();
            }
                
        }

       
    }
}
