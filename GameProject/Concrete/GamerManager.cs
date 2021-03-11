using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

       
    }
}
