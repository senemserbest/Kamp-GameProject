using Kamp_GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_GameProject.Abstract
{
    public interface IGamerCheckService
    {
        bool Check(Gamer gamer);
    }
}
