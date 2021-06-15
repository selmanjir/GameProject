using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GameSaleManager : IGameSaleService
    {

        public void Sale(Game game,Gamer gamer , Campaign campaign)
        {
            Console.WriteLine(game.GameName + " " + "Oyunu" + " " + gamer.FirstName + " " + gamer.LastName + " " + "Tarafından satın alındı" + " " + campaign.CampaignName + " " + "Kampanyası uygulandı. Fiyatı" + " " + game.GamePrice + " " + "iken " + " " + campaign.CampaignName + "sayesinde  " + " "    + (game.GamePrice - (game.GamePrice*campaign.CampaignDiscount/100)) + " oldu " );
        }
    }
}
