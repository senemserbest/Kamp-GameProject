using Kamp_GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_GameProject.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
