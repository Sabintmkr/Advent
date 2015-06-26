using System.Web.Mvc;

namespace Advent.Controllers
{
    public class EntryController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToRoute("");

            return RedirectToAction("SignIn");
        }
    }
}