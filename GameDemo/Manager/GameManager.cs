using System;
using GameDemo.Abstract;
using GameDemo.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class GameManager : IGameSystem
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game " + game.Name + " is added. Price is " + game.Price);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game " + game.Name + " is deleted.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game " + game.Name + " is updated.");
        }
    }
}
