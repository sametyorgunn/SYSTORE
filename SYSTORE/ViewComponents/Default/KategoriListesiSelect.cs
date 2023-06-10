using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.ViewComponents.Default
{
	public class KategoriListesiSelect:ViewComponent
	{
		private readonly IKategoriService _kategoriservice;

		public KategoriListesiSelect(IKategoriService kategoriservice)
		{
			_kategoriservice = kategoriservice;
		}

		public IViewComponentResult Invoke()
		{
			var kategori = _kategoriservice.GetList();
			return View(kategori);
		}
	}
}
