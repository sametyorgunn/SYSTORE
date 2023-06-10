using BusinessLayer.Abstract;
using EntityLayer.Enums;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.ViewComponents.Default
{
    public class UrunEkleVaryantRenkDegerListesi:ViewComponent
    {
        private readonly IVaryantDegerService _degerservice;

        public UrunEkleVaryantRenkDegerListesi(IVaryantDegerService degerservice)
        {
            _degerservice = degerservice;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _degerservice.GetListAll(x => x.Varyantid == (int)VaryantTuru.VaryantTipi.Renk);
            return View(degerler);
        }
    }
}
