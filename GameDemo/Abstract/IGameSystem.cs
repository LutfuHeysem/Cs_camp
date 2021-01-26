using System;
using GameDemo.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGameSystem
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
