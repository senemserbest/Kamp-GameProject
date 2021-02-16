using Kamp_GameProject.Abstract;
using Kamp_GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_GameProject.Concrete
{
    class GamerManager : IGamerService
         
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer)==true)
            {
                Console.WriteLine(gamer.GamerUserName + " added.");
            }
            else
            {
                Console.WriteLine("Checking couldn't succeed.");    
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerUserName + " deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerUserName + " updated.");
        }
    }
}
