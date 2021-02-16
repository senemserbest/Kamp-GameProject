using Kamp_GameProject.Abstract;
using Kamp_GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_GameProject.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
      public bool Check(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.GamerFirstName == "SENEM" && gamer.GamerLastName == "SERBEST" && gamer.NationalIdentity == 1234567890)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
