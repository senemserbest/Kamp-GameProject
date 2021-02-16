using Kamp_GameProject.Abstract;
using Kamp_GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is updated.");
        }
    }
}
