using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.ViewComponents.Default
{
	public class UrunEkleVaryantListesi:ViewComponent
	{
		private readonly IVaryantService _varyantservice;

        public UrunEkleVaryantListesi(IVaryantService varyantservice)
        {
            _varyantservice = varyantservice;
        }

        public IViewComponentResult Invoke()
		{
			var varyantlar = _varyantservice.GetListAll(x => x.VaryantDurumu == 1).ToList();
			return View(varyantlar);
		}
	}
}
