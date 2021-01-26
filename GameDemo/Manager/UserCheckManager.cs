using System;
using GameDemo.Abstract;
using GameDemo.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class UserCheckManager : IPlayerCheckSystem
    {
        public bool CheckRealPerson(Player player)
        {
            return true;
        }
    }
}
