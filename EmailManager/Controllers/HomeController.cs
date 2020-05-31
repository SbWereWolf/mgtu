using System.Web.Mvc;
using EmailManager.Models;

namespace EmailManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new UserList().GetAll();
            return View(list);
        }
    }
}
