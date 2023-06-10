using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Enums;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.ViewComponents.Default
{
    public class UrunEkleVaryantBedenDegerListesi:ViewComponent
    {
        private readonly IVaryantDegerService _degerservice;

        public UrunEkleVaryantBedenDegerListesi(IVaryantDegerService degerservice)
        {
            _degerservice = degerservice;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _degerservice.GetListAll(x=>x.Varyantid==(int)VaryantTuru.VaryantTipi.Beden);
            return View(degerler);
        }
    }
}
