using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public class SalesManager:Campaign
    {
        public void ApplyDiscount(Product product, Campaign campaign)
        {
            double unitPrice = Convert.ToDouble(product.ProductUnitPrice);
            double discountRate = Convert.ToDouble(campaign.DicountRate);

            unitPrice = unitPrice - unitPrice * discountRate;

            Console.WriteLine("Oyun {0} - Birim Fiyatı : {1}\n Kampanya Adı : {2} - İndirim Oranı {3} --> İndirimli Fiyat : {4}\n",
                product.ProductName,product.ProductUnitPrice,campaign.CampaignName,campaign.DicountRate,unitPrice);

        }
    }
}
