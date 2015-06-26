using System.Web.Mvc;

namespace Advent.Controllers
{
    public class ArticlesController : Controller
    {
        //
        // GET: /Articles/
        public ActionResult Index()
        {
            return View();
        }
    }
}