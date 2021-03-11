using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Add to " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Delete to " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Update to " + game.GameName);
        }
    }
}
