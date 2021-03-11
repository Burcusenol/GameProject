using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "Burcu", LastName = "Şenol", DateOfBirth = new DateTime(1998, 2, 7), NationalityId = "54634460518" };

            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            Game game1 = new Game() { GameId = 10, GameName = "ABC", GamePrice = 200 };

            Campaign campaign1 = new Campaign() { CampaignId = 1, CampaignName = "CBA", CampaignDiscount ="% 50 "};
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(gamer1,game1);
            salesManager.CampaignSales(gamer1, game1, campaign1);

        }
        
    }
}
