using System.Web.Mvc;
using Validation2_gyak.Models;

namespace Validation2_gyak.Controllers
{
    public class GyakController : Controller
    {
        // GET: Gyak
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RandomModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return View();
            }
        }

    }
}