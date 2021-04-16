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

        public ActionResult TeamDetails(int ID)
        {
            Session["Message"] = null;
            if (ID <= 10)
            {
                Session["TeamName"] = DataStore.GetTeamName(ID);
                return View(DataStore.GetTeamPlayers(ID));
            }
            else
            {
                Session["Message"] = "Information Not Available for this team";
                return RedirectToAction("Index");
            }
        }

    }
}