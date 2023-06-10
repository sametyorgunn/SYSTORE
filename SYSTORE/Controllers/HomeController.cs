using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace SYSTORE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUrunService _urunservice;

		public HomeController(ILogger<HomeController> logger, IUrunService urunservice)
		{
			_logger = logger;
			_urunservice = urunservice;
		}

		public IActionResult Index()
        {
			var uruns = _urunservice.UrunListKategorisiIle();
			return View(uruns);
        }
        
        public IActionResult UrunDetay(int id)
        {
            var urun = _urunservice.TGetById(id);
            return View(urun);
        }

        public IActionResult Urunler(int id)
        {
            var uruns = _urunservice.UrunListesiGetirKategoriyeGore(id);
            return View(uruns);
        }

     

      
    }
}