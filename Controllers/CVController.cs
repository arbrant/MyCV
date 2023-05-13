using CV.Models;
using CV.Services;
using Microsoft.AspNetCore.Mvc;

namespace CV.Controllers
{
    public class CVController : Controller
    {
        private static CV_Info _info = CreateCVArtenHerasymchuk.CreateCVArtemHersymchuk();

        public IActionResult Index()
        {
            return View(_info);
        }
    }
}
