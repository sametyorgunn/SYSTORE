using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.Areas.Uye.Controllers
{
	[Area("Uye")]
	public class UyePanelController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
