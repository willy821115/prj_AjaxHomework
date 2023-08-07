using Microsoft.AspNetCore.Mvc;

namespace prj_AjaxHomework.Controllers
{
    public class HomeworkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
