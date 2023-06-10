using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MarkaController : Controller
    {
        private readonly IMarkaService _markaService;

        public MarkaController(IMarkaService markaService)
        {
            _markaService = markaService;
        }

        public IActionResult Markalar()
        {
            var marka = _markaService.GetList();
            return View(marka);
        }
        [HttpPost]
        public IActionResult MarkaEkle(Marka Marka)
        {
            _markaService.TAdd(Marka);
            return RedirectToAction("Markalar", "Marka");
        }
        public IActionResult MarkaDuzenle(int id)
        {
            var marka = _markaService.TGetById(id);
            return View(marka);
        }
        [HttpPost]
        public IActionResult MarkaDuzenle(Marka marka)
        {
            _markaService.TUpdate(marka);
            return RedirectToAction("Markalar", "Marka");
        }

        public IActionResult MarkaPasifYap(int id)
        {
            var marka = _markaService.TGetById(id);
            marka.MarkaDurumu = 0;
            _markaService.TUpdate(marka);
            return RedirectToAction("Markalar", "Marka");
        }

        public IActionResult MarkaAktifYap(int id)
        {
            var marka = _markaService.TGetById(id);
            marka.MarkaDurumu = 1;
            _markaService.TUpdate(marka);
            return RedirectToAction("Markalar", "Marka");
        }

        public IActionResult MarkaSil(int id)
        {
            var marka = _markaService.TGetById(id);
            _markaService.TDelete(marka);
            return RedirectToAction("Markalar", "Marka");
        }
    }
}
