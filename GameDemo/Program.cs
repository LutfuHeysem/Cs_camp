using System;
using GameDemo.Entities;
using GameDemo.Abstract;
using GameDemo.Manager;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                Name = "Lütfü",
                Nick = "Meydanlaurus",
                NationalityId = "12435265632",
                AccountBalance = 350,
                Age = 16,
                PlayerId = 1
            };
            Player player2 = new Player
            {
                Name = "Furkan",
                Nick = "Asimsek",
                NationalityId = "09876578789",
                AccountBalance = 500,
                Age = 25,
                PlayerId = 2
            };
            Player player3 = new Player
            {
                Name = "Esat",
                Nick = "McJester",
                NationalityId = "96758430129",
                AccountBalance = 200,
                Age = 14,
                PlayerId = 3
            };

            Player[] players = new Player[] { player1, player2, player3};

            Game WD = new Game
            {
                Name = "Watch Dogs",
                Price = 150,
                AgeRestriction = 16,
            };
            Game GTAV = new Game
            {
                Name = "GTA V",
                Price = 250,
                AgeRestriction = 17,
            };
            Game FIFA20 = new Game
            {
                Name = "FIFA 20",
                Price = 180,
                AgeRestriction = 5,
            };

            Game[] games = new Game[] { WD, GTAV, FIFA20};

            Campaign newYearCampaign = new Campaign
            {
                AmounOfDiscount = 60,
                StartDate = 1,
                FinalDate = 31,
                Name = "NewYear"
            };
            Campaign valentinesDay = new Campaign
            {
                AmounOfDiscount = 40,
                StartDate = 14,
                FinalDate = 21,
                Name = "ValentinesDay"
            };
            Campaign special = new Campaign
            {
                AmounOfDiscount = 150,
                StartDate = 3,
                FinalDate = 5,
                Name = "Special"
            };

            Campaign[] campaigns = new Campaign[] { newYearCampaign, valentinesDay, special};

            PlayerManager playerManager = new PlayerManager();
            foreach(var player in players)
            {
                playerManager.Add(player);
                playerManager.NickUpdate(player, "yeni nick");
            }

            IGamePurchaseSystem purchaseManager = new PurchaseManager();
            purchaseManager.Buy(GTAV, newYearCampaign, 4, player3);
            purchaseManager.Buy(WD, valentinesDay, 20, player1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Update(newYearCampaign);
        }
    }
}
