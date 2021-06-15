using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using GameProject.Concrete;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        public GamerManager()
        {

        }

        private IPersonCheckService personCheckService;
        public GamerManager(IPersonCheckService personCheckService)
        {
            this.personCheckService = personCheckService;
        }
        public void Save(Gamer gamer)
        {
            if (personCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + "isimli oyuncu kaydı gerçekleştirildi");
            }
            else
            {
                Console.WriteLine("Bilgilerinizi kontrol edip tekrar deneyiniz.");
            }
            
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine( gamer.FirstName + "İsimli oyuncu kaydı silindi");
        }

        

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "İsimli oyuncu kaydı güncellendi");
        }
    }
}
