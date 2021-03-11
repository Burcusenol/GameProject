using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public  virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Added to: " + gamer.FirstName);
        }

        public  virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted to: " + gamer.FirstName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Updated to: " + gamer.FirstName);
        }
    }
}
