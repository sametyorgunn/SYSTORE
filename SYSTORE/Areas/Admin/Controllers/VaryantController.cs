using BusinessLayer.Abstract;
using EntityLayer.Dtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.Data.SqlClient.DataClassification;
using System.IO.IsolatedStorage;

namespace SYSTORE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VaryantController : Controller
    {
        private readonly IVaryantService _varyantService;
        private readonly IVaryantDegerService _varyantdegerservice;
        private readonly IVaryantDegerMapService _varyantdegermapservice;

        public VaryantController(IVaryantService varyantService, IVaryantDegerService varyantdegerservice, IVaryantDegerMapService varyantdegermapservice)
        {
            _varyantService = varyantService;
            _varyantdegerservice = varyantdegerservice;
            _varyantdegermapservice = varyantdegermapservice;
        }

        public IActionResult Varyantlar()
        {
            var varyantlar = _varyantService.VaryantVeDegerGetir();
            return View(varyantlar);
        }

        public IActionResult VaryantEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VaryantEkle(VaryantEkleDto dto)
        {
            Varyant varyant = new Varyant
            {
                VaryantAdi = dto.VaryantAdi,
                VaryantDurumu = 1
            };
            _varyantService.TAdd(varyant);

            foreach (var i in dto.VaryantDegerAdi)
            {
                VaryantDeger deger = new VaryantDeger
                {
                    Varyantid = varyant.Id,
                    VaryantDegerAdi = i,
                    VaryantDegerDurumu = 1,
                    VaryantDegerResim = "fdsf",
                };
                _varyantdegerservice.TAdd(deger);
            }
            return RedirectToAction("VaryantEkle", "Varyant");
        }

        public IActionResult VaryantDuzenle(int id)
        {
            var varyants = _varyantService.VaryantVeDegerleriniGetir(id);
            return View(varyants);
        }
        [HttpPost]
        public IActionResult VaryantDuzenle(VaryantDuzenleDto dto)
        {

            Varyant varyant = new Varyant
            {
                Id = dto.VaryantId,
                VaryantAdi= dto.VaryantAdi,
                VaryantDurumu = dto.VaryantDurumu
                
            };
            _varyantService.TUpdate(varyant);

            foreach (var i in dto.DegerlerDizi)
            {
                VaryantDeger deger = new VaryantDeger
                {
                    Id = i.Id,
                    VaryantDegerAdi = i.Deger,
                    Varyantid= varyant.Id,
                };
                _varyantdegerservice.TUpdate(deger);
            }

            return RedirectToAction("Varyantlar", "Varyant");












            //var id = HttpContext.Session.GetInt32("varyantid");
            //var degers = _varyantdegerservice.GetListAll(x => x.Varyantid == id).ToList();
            //foreach (var item in degers)
            //{
            //    var itemDeger = dto.DegerlerDizi.Where(x => x.Id == item.Id).FirstOrDefault();

            //    if (itemDeger != null)
            //    {
            //        item.VaryantDegerAdi = itemDeger.Deger;
            //        _varyantdegerservice.TUpdate(item);
            //    }
            //}


            return RedirectToAction("VaryantDuzenle", "Varyant");
        }

        [HttpPost]
        public IActionResult VaryantSil(int id)
        {
            var varyantdeger = _varyantdegerservice.TGetById(id);
            _varyantdegerservice.TDelete(varyantdeger);

            return Ok();

        }
    }
}
