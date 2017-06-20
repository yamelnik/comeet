using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server.Controllers
{
    public class ProfileViewsController : Controller
    {
        // GET: ProfileViews
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
    }
}