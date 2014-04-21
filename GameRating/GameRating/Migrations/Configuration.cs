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
                Name = "Fallout 3",
                System = "PS3",
                Rating = 5
            },

            new Game
            {
                Name = "Fallout: New Vegas ",
                System = "PS3",
                Rating = 3
            }
            );
        }
    }
}
