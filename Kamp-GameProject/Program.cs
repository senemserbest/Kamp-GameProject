using Kamp_GameProject.Abstract;
using Kamp_GameProject.Concrete;
using Kamp_GameProject.Entity;
using System;

namespace Kamp_GameProject
{
    class Program
    {
        

        static void Main(string[] args)

        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer {GamerID = 1, BirthYear = 2000, GamerFirstName ="SENEM", GamerLastName = "SERBEST", NationalIdentity = 1234567890, GamerUserName = "player1"} ;
            gamerManager.Add(gamer1);
            
            Game game1 = new Game {GameId = 3, GameName = " Disco Elysium ", GamePrice = 33.55};
            Game game2 = new Game { GameId = 4, GameName = " Portal ", GamePrice = 18.50 };

            Campaign campaign1 = new Campaign { CampaignName = "New Year Campaign", DiscountRate = 80 };
            Campaign campaign2 = new Campaign { CampaignName = "Gaming Festival Campaign", DiscountRate = 50 };

            DiscountManager discountManager = new DiscountManager();
            discountManager.Discount(game1, gamer1 , campaign2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign1);

           
           
           







        }
    }
}
