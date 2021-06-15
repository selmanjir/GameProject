using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}
