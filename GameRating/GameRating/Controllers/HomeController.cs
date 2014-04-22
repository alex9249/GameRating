using GameRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameRating.Controllers
{
    public class HomeController : Controller
    {
        private GameDBContext db = new GameDBContext();
        public int staticID = IDHolder.ID;
         
        public ActionResult Index()
        {
            
            Game game = db.Games.Find(staticID);
            return View(game);
           
        }
        
       public ActionResult Next()
        {
            Game game = db.Games.Find(staticID+1);
           if (game != null)
           {
               staticID += 1;
               game = db.Games.Find(staticID);
               IDHolder.ID = staticID;
           }
           else
               game = db.Games.Find(staticID);
           return View(game);
        }

        
    }
}