using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Server.Controllers
{
    [EnableCors(origins:"*", headers:"*",methods:"*")]
    public class HomeController : Controller
    {
        // GET: Views
        public ActionResult Index()
        {
            return Redirect("/api/ProfileViews/Index");
        }
    }
}