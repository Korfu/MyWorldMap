using Microsoft.AspNetCore.Mvc;
using MyWorldMapApp.Repositories;

namespace MyWorldMapApp.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly ITravelDestinationRepository _travelDestinationRepository;

        public UsersController(IUserRepository userRepository, 
                               ITravelDestinationRepository travelDestinationRepository)
        {
            _userRepository = userRepository;
            _travelDestinationRepository = travelDestinationRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = _userRepository.GetAll();
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return RedirectToAction("Add");
        }

        [HttpPost]
        public IActionResult Add(UserViewModel user)
        {
            var userIdToBeSaved = _userRepository.Add(user);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit()
        {
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Edit(UserViewModel model)
        {
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete()
        {
            return RedirectToAction("Index");

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");

        }

    }
}