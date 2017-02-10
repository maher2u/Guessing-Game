using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;




namespace Guss.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }
       public static int Count = 0;
       public static int Right = 0;
       public static int lower = 0;
       public static int higher = 0;
       public ActionResult Guess(int? guess)
        {


            Random a = new Random();
            int answer=a.Next(0, 101);
           



            if (guess>answer)
            {
                ViewBag.msg = " Guess Lower ..";
                ViewBag.Count = Count;
                ViewBag.lCount = lower;

            }
           else if (guess<answer )
            {
                ViewBag.msg = "Guess higher..";
                ViewBag.Count = Count;
                ViewBag.hCount = higher;

            }
            else 
            {
                ViewBag.msg = "You Found it..";
                ViewBag.Count = Count;
                ViewBag.rCount = Right;
            }


            Count++;
            Right++;
            lower++;
            higher++;
            return View();

        }

        
        
    }
}