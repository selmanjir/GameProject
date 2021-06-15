using System;
using System.Collections.Generic;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;


namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Gamer gamer0 = new Gamer { NationalityId = "18985858580", FirstName = "Selman Jir ", LastName = "CAN" };
            Gamer gamer1 = new Gamer { NationalityId = "1893030300", FirstName = "Ardıl", LastName = "ELKAAN" };
            Gamer gamer2 = new Gamer { NationalityId = "18988833318", FirstName = "Recep", LastName = "DEMİRÖREN" };

            
            Game game0 = new Game { Id = 1, GameName = "GTA", FileSizeInGb = 18,GamePrice = 100  };
            Game game1 = new Game { Id = 2, GameName = "Valorant", FileSizeInGb = 6.9f , GamePrice = 30};
            Game game2 = new Game { Id = 3, GameName = "Assassin's creed ", FileSizeInGb = 4 , GamePrice = 70 };
            Game game3 = new Game { Id = 4, GameName = "Skyrim", FileSizeInGb = 4.5f, GamePrice = 50 };
            
            
            Campaign campaign0 = new Campaign { Id = 0, CampaignName = "Hiçbir", CampaignDiscount = 0 };
            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Yüzde 50 indirim", CampaignDiscount = 50 };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "Yüzde 25 indirim", CampaignDiscount = 25 };

            GamerManager gamerManager = new GamerManager(new PersonCheckManager());
            gamerManager.Save(gamer0);
            Console.WriteLine("-----------------------");
            gamerManager.Save(gamer1);
            Console.WriteLine("-----------------------");
            gamerManager.Delete(gamer0);
            Console.WriteLine("-----------------------");
            gamerManager.Update(gamer1);
            Console.WriteLine("-----------------------");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(game0, gamer2, campaign2);
            Console.WriteLine("-----------------------");
            gameSaleManager.Sale(game1, gamer0, campaign1);
            Console.WriteLine("-----------------------");
            gameSaleManager.Sale(game2, gamer1, campaign0);


        }
    }
}
