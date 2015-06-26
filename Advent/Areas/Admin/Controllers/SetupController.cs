using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Advent.Areas.Install.Models;
using Advent.Library;
using Advent.Library.Vendors;
using Advent.Models;

namespace Advent.Areas.Admin.Controllers
{
    public class SetupController : Controller
    {
        private readonly AdventDbContext _db;

        public SetupController(AdventDbContext db)
        {
            _db = db;

            // Show a "page not found" error if the app is already installed
            if (Config.AdventInstalled)
                throw new HttpException(404, "Page not found.");
        }

        // GET: Install/Setup
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(SetupViewModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.AdminPassword)
                && !string.IsNullOrWhiteSpace(model.AdminConfirmPassword)
                && !model.AdminPassword.Equals(model.AdminConfirmPassword))
            {
                ModelState.AddModelError("AdminConfirmPassword",
                    "The field Admin Confirm Password does not match the field Admin Password.");
            }

            if (!ModelState.IsValid)
                return View(model);

            // Create administrator account
            _db.Users.Add(new User
            {
                Name = model.AdminName,
                Password = PasswordStorage.CreateHash(model.AdminPassword),
                Email = model.AdminEmail
            });

            await _db.SaveChangesAsync();

            return RedirectToAction("Index", "Dashboard");
        }
    }
}