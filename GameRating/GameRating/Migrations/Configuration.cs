namespace GameRating.Migrations
{
    using GameRating.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameRating.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameRating.Models.GameDBContext context)
        {
            context.Games.AddOrUpdate(i => i.Name,
                new Game
                {
                    Name = "Super Mario",
                    System = "Nintendo 64",
                    Rating = 10
                },

                new Game
                {
                Name = "Goat Simulator",
                System = "PC",
                Rating = 9000
                }
                );
        }
    }
}
