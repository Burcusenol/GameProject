using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Add to "+campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Delete to " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Update to " + campaign.CampaignName);
        }
    }
}
