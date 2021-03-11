using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
   public interface ISalesService
    {
        void Sale(Gamer gamer,Game game);
        void CampaignSales(Gamer gamer, Game game, Campaign campaign);
    }
}
