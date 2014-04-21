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
        public ActionResult Index()
        {
            int id = 1;
            Game game = db.Games.Find(id);
            return View(game);
        }

        
    }
}