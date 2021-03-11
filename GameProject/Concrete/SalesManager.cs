using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        public void CampaignSales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " sold to: "+gamer.FirstName+" "+gamer.LastName+" with"+ campaign.CampaignDiscount+"discount.");
        }

        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName+"sold to: "+gamer.FirstName+" "+gamer.LastName);
        }
    }
}
