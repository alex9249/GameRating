using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace GameRating.Models
{
    public class Game
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string System { get; set; }
        public int Rating { get; set; }


    }
    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

    }

   
    
}


