using System;
using GameDemo.Entities;
using GameDemo.Manager;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IGamePurchaseSystem
    {
        void Buy(Game game, Campaign campaign, int currentDate, Player player);
    }
}
