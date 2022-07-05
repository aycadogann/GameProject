using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} oyunu eklendi", game.Name);
        }
        public void Update(Game game)
        {
            Console.WriteLine("{0} oyunu güncellendi", game.Name);
        }
        public void Remove(Game game)
        {
            Console.WriteLine("{0} oyunu silindi", game.Name);
        }

       
    }
}
