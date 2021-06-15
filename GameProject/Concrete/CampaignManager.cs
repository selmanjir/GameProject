using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException(campaign.CampaignName + "Güncellendi");
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException(campaign.CampaignName + "Silindi");
        }
    }
}
