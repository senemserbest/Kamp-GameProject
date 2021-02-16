using Kamp_GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_GameProject.Concrete
{
    public class GameManager
    {
        internal void Add(Game game)
        {
            Console.WriteLine(game.GameName+" is added.");
        }
    }
}
