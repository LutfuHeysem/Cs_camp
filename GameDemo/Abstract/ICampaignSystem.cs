using System;
using GameDemo.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ICampaignSystem
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
