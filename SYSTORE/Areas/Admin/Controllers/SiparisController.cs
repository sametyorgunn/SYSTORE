using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SiparisController : Controller
    {
        private readonly ISiparisService _siparisservice;

        public SiparisController(ISiparisService siparisservice)
        {
            _siparisservice = siparisservice;
        }

        public IActionResult Siparisler()
        {
            var siparisler = _siparisservice.SiparisUyeBilgileriTopluGetir();
            return View(siparisler);
        }

        public IActionResult SiparisDetay(int id)
        {
            return View();
        }
    }
}
