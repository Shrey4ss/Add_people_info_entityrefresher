using Microsoft.AspNetCore.Mvc;

namespace Add_people_info_entityrefresher.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
