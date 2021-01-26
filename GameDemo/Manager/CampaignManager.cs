using System;
using GameDemo.Entities;
using GameDemo.Abstract;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class CampaignManager : ICampaignSystem
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign " + campaign.Name + " is added, final date is " + campaign.FinalDate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign " + campaign.Name + " is deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign " + campaign.Name + " is updated.");
        }
    }
}
