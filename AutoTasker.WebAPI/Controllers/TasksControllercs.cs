using Microsoft.AspNetCore.Mvc;

namespace AutoTasker.WebAPI.Controllers
{
    public class TasksControllercs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
