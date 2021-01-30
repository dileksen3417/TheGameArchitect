using System;
using System.Collections.Generic;
using System.Text;
using TheGameArchitect.Entities;

namespace TheGameArchitect.Abstract
{
    class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası sisteme eklenmiştir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası sistemden silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası bilgileri güncellenmiştir.");
        }
    }
}
