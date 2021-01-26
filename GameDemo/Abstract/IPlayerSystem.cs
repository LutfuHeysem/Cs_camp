using System;
using GameDemo.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IPlayerSystem
    {
        void Add(Player player);
        void NickUpdate(Player player, string newNick);
        void BalanceUpdate(Player player, int newBalance);
        void Delete(Player player);
    }
}
