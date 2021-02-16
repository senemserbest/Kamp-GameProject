using Kamp_GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_GameProject.Abstract
{
    public interface IDiscountService
    {
        void Discount(Game game, Gamer gamer,Campaign campaign);
    }
}
