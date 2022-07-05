using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer 
            {
                Id=1,
                FirstName="Alara",
                LastName="Çiçek",
                NationalityId="22222222222",
                DateOfBirth=new DateTime(2000,2,2)
            };
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Save(gamer);
            gamerManager.Update(gamer);
            gamerManager.Remove(gamer);

            Game game = new Game 
            {
            Id=1,
            Name="Game-1",
            Price=550
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Remove(game);

            Campaign campaign = new Campaign 
            { 
                Id=1,
                Name="Kampanya-1",
                Discount=30
            };

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer, game, campaign);

            OfferManager offerManager = new OfferManager();
            offerManager.Add(campaign);
            offerManager.Remove(campaign);
            offerManager.Update(campaign);



        }
    }
}
