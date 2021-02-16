using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public class BaseGamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer)== true)
            {
                
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Kullanıcı oluşturuldu.");

            }
            else
            {
                Console.WriteLine("Kimlik Doğrulanamadı.");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "" + gamer.LastName + "Güncellendi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "" + gamer.LastName + "Silindi.");
        }

        public void GetAll(List<Gamer> gamers)
        {
            throw new NotImplementedException();
        }

        IGamerCheckService _gamerCheckService;

        public BaseGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        
    }
}
