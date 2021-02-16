using Kamp_GameProject.Abstract;
using Kamp_GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_GameProject.Concrete
{
    public class DiscountManager : IDiscountService
    {
        public void Discount(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerUserName + " bought " + game.GameName + "with " + campaign.CampaignName);
        }

        internal void Discount(Game game1, object gamer2, Campaign campaign2)
        {
            throw new NotImplementedException();
        }
    }
}
