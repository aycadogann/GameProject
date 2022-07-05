using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("{0} oyununa {1} TL indirim ile  {2} {3} kullanıcısına satıldı.",game.Name,campaign.Discount,gamer.FirstName,gamer.LastName);
        }
    }
}
