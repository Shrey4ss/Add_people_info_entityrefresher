using Add_people_info_entityrefresher.Interface;
using Add_people_info_entityrefresher.Models;
using Microsoft.AspNetCore.Mvc;

namespace Add_people_info_entityrefresher.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleController(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(People people)
        {
            if(ModelState.IsValid) 
            {
                People pe = new People()
                {
                    FName = people.FName,
                    Lname = people.Lname,
                    Age = people.Age,
                    About = people.About
                };
                _peopleRepository.Add(pe);
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }

        public IActionResult ViewPeople()
        {
            var all = _peopleRepository.Getall();
            return View(all);
        }
    }
}
