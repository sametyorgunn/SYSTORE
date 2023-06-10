using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.ViewComponents.Default
{
	public class MenuKategoriListe:ViewComponent
	{
		
		private readonly IKategoriService _kategoriService;
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
