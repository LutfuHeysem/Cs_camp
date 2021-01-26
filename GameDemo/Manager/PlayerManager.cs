using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class PlayerManager : IPlayerSystem
    {
        public void Add(Player player)
        {
            UserCheckManager playerCheck = new UserCheckManager();
            if (playerCheck.CheckRealPerson(player) == true)
            {
                Console.WriteLine("Player " + player.Nick + " is added.");
            }
            else
            {
                Console.WriteLine("Invalid user!");
            }
        }

        public void NickUpdate(Player player, string newNick)
        {
            Console.WriteLine("Player " + player.PlayerId + "'s nickname is updated, new nicname is : " + newNick);
        }

        public void BalanceUpdate(Player player, int newBalance)
        {
            Console.WriteLine("Player " + player.Nick + "'s balance is updated, new balance is : " + newBalance);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player " + player.Nick + " is deleted.");
        }
    }
}
