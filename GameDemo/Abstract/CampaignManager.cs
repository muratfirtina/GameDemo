using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} kampanya eklendi", campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} kampanya güncellendi", campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} kampanya silindi", campaign.CampaignName);
        }

        public void GetAll(List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("Kampanya Id : {0} - Kampanya Adı : {1} - Kampanya Fiyatı : {2}\n",
                    campaign.CampaignId, campaign.CampaignName, campaign.DicountRate);

            }

            Console.ReadLine();

        }
    }
}