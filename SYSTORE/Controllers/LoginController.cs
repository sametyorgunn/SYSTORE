using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace SYSTORE.Controllers
{
	public class LoginController : Controller
	{
		private readonly IUyeService _uyeservice;

		public LoginController(IUyeService uyeservice)
		{
			_uyeservice = uyeservice;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Uye uye)
		{
			var giris = _uyeservice.UyeLoginKontrol(uye);
			if(giris != null)
			{
				HttpContext.Session.SetInt32("uyeid",giris.Id);
				return RedirectToAction("Index", "Profil");
			}
			else
			{
				return View();
			}
		}
		public IActionResult Kayit()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Kayit(Uye uye)
		{
			_uyeservice.TAdd(uye);
			return RedirectToAction("Index");
		}
	}
}
