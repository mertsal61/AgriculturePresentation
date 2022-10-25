using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AnnoucementsControler : Controller
    {
        private readonly iAnnoucementService _annoucementService;

        public AnnoucementsControler(iAnnoucementService annoucementService)
        {
            _annoucementService = annoucementService;
        }

        public IActionResult Index()
        {
            var values = _annoucementService.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult AddAnnoucement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnoucement(Annoucement p)
        {
            _annoucementService.Insert(p);
            return RedirectToAction("Index");
        }
                
        public IActionResult DeleteAnnoucement(int id)
        {
            var values = _annoucementService.GetByID(id);
            _annoucementService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAnnoucement(int id)
        {
            var values=_annoucementService.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAnnoucement(Annoucement a)
        {
            _annoucementService.Update(a);
            return RedirectToAction("Index");
        }



    }
}
