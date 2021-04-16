using FootballClubApp.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballClubApp.Controllers
{
    public class HomeController : Controller
    {
        IDataRepository DataStore = new DataRepository();
        public ActionResult Index()
        {
            return View(DataStore.GetAllTeams());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}