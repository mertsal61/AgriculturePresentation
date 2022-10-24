using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ServiceController : Controller
    {
        private readonly iServiceService _iServiceService;

        public ServiceController(iServiceService iServiceService)
        {
            _iServiceService = iServiceService;
        }

        public IActionResult Index()
        {
            var values =_iServiceService.GetAll();

            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _iServiceService.Insert(service);
            return RedirectToAction("Index");
        }

        public IActionResult deneme()
        {
            return View();
        }


    }
}
