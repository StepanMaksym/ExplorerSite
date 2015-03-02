using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExplorerLviv.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/


        [ActionName("List")]
        public ActionResult Search(string name = "Rembo")
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                var message = Server.HtmlEncode(name);

                //redirects to particular URL
                //return RedirectPermanent("url address here");

                // Redirects to Action (Action, Controller, custom parameters as anonymous object)
                //return RedirectToAction("Search", "Database", new {name = "The result of database search"});

                // Redirects to some determined route
                //return RedirectToRoute("Default", new {controller = "Home", action = "About"});

                return File(Server.MapPath("~/Content/site.css"), "text/css");
            }

            return View("Cuisine");
        }

        public ActionResult test()
        {
            return Content("Test");
        }
    }
}