using System.Web.Mvc;
using ExplorerLviv.Models;

namespace ExplorerLviv.Controllers
{
    public class DatabaseController : Controller
    {
        //
        // GET: /Database/

        public ActionResult Index()
        {
            var model = new DatabaseModel();
            model.Description = "This is Database controller";
            return View(model);
        }

        public ActionResult Search(string name)
        {
            var model = new DatabaseModel();
            model.Description = Server.HtmlEncode(name);
            return View("Index", model);
        }

    }
}
