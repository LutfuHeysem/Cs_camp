using System;
using GameDemo.Entities;
using GameDemo.Abstract;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    public class PurchaseManager : IGamePurchaseSystem
    {
        public void Buy(Game game, Campaign campaign, int currentDate, Player player)
        {
            if(currentDate >= campaign.StartDate && currentDate <= campaign.FinalDate && player.AccountBalance >= (game.Price-campaign.AmounOfDiscount) && player.Age >= game.AgeRestriction && campaign.AmounOfDiscount <= game.Price)
            {
                Console.WriteLine("Purchase successful with campaign : " + campaign.Name + ", game purchased : " + game.Name);
                Console.WriteLine("New account balance for " + player.Nick + " is : " + (player.AccountBalance-(game.Price-campaign.AmounOfDiscount)));
            }
            else if(!(currentDate >= campaign.StartDate && currentDate <= campaign.FinalDate) && player.AccountBalance >= game.Price)
            {
                Console.WriteLine("Purchase successful without campaign, game purchased : " + game.Name);
                Console.WriteLine("New account balance for " + player.Nick + " is : " + (player.AccountBalance - game.Price));
            }
            else
            {
                Console.WriteLine("Purchase unsuccessful =( ");
            }
        }
    }
}
