using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class OfferManager : IOfferService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} kampanyası eklendi",campaign.Name);
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("{0} kampanyası silindi", campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} kampanyası güncellendi", campaign.Name);
        }
    }
}
