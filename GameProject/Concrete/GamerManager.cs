using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService) 
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("{0} {1} kayıt edildi", gamer.FirstName, gamer.LastName);
            }
            else
            {
                Console.WriteLine("Geçersiz kullanıcı");
            } 
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0} {1}  kayıt güncellendi", gamer.FirstName, gamer.LastName);
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("{0} {1} kayıt silindi", gamer.FirstName, gamer.LastName);
        }
    }
}

       

 