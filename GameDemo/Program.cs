using System;
using System.Collections.Generic;
using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Entities;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Üye Kaydı*********");

            BaseGamerManager gamerManager = new BaseGamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Entities.Gamer
            {
                DateOfBirth = new DateTime(1983, 9, 23), 
                FirstName = "MURAT", 
                LastName = "FIRTINA", 
                NationalityId = "44689425372"
            });
            Console.ReadLine();

            Product product1 = new Product {ProductId = 10, ProductName = "FIFA2021", ProductUnitPrice = 90};
            Product product2 = new Product {ProductId = 11, ProductName = "NFS7", ProductUnitPrice = 80};
            Product product3 = new Product {ProductId = 12, ProductName = "PES2021", ProductUnitPrice = 95};

            Campaign campaign1 = new Campaign { CampaignId = 20, CampaignName = "Yeni Yıl", DicountRate = 10 };
            Campaign campaign2 = new Campaign { CampaignId = 21, CampaignName = "Hızlı ve Ucuz", DicountRate = 15 };
            Campaign campaign3 = new Campaign { CampaignId = 22, CampaignName = "Futbol Haftası", DicountRate = 5 };

            ProductManager productManager = new ProductManager();
            CampaignManager campaignManager = new CampaignManager();
            SalesManager salesManager = new SalesManager();

            Console.WriteLine("************Oyunlar************\n");
            List<Product> productsList = new List<Product> {product1, product2, product3};
            productManager.GetAll(productsList);

            Console.WriteLine("************Kampanyalar************\n");
            List<Campaign> campaignList = new List<Campaign> { campaign1, campaign2, campaign3 };
            campaignManager.GetAll(campaignList);



        }
    }
}
