using Microsoft.AspNetCore.Mvc;
using RequestApp.Models;

namespace RequestApp.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repo) => repository = repo;
        public IActionResult Index()
        {
            return View(repository.Requests);
        }

        [HttpPost]
        public IActionResult AddRequest(Request request)
        {
            repository.AddRequest(request);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateRequest(int key)
        {
            return View(repository.GetRequest(key));
        }

        [HttpPost]
        public IActionResult UpdateRequest(Request request)
        {
            repository.UpdateRequest(request);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteRequest(Request request)
        {
            repository.DeleteRequest(request);
            return RedirectToAction(nameof(Index));
        }
    }
}
