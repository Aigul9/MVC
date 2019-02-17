using System.Web.Mvc;
using mvc_5.Models;

namespace mvc_5.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var newForm = new InputForm();
            return View(newForm);
        }

        [HttpPost]
        public ActionResult Index(InputForm form)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("End");
            }
            else
            {
                return View(form);
            }
        }

        public string End(InputForm form)
        {
            return "Success";
        }
    }
}