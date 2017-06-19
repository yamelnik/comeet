using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Server.Controllers
{
    public class HomeController : Controller
    {
        // GET: Views
        public ActionResult Index()
        {
            return View(); 
        }
    }
}