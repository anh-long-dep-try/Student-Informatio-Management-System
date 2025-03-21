using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Repositories;

namespace SIMS_Project.Controllers
{
    public class UserController : Controller
    {
        //constructor
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
