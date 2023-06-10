using BusinessLayer.Abstract;
using EntityLayer.Entities;
using EntityLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SYSTORE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrunController : Controller
    {
        private readonly IUrunService _urunservice;
        private readonly IUrunCokluResimService _uruncokluresim;
        private readonly IUrunVaryantDegerService _urunvaryantdeger;
        private readonly IWebHostEnvironment _webHost;

        public UrunController(IUrunService urunservice, IUrunCokluResimService uruncokluresim, IWebHostEnvironment webHost, IUrunVaryantDegerService urunvaryantdeger)
        {
            _urunservice = urunservice;
            _uruncokluresim = uruncokluresim;
            _webHost = webHost;
            _urunvaryantdeger = urunvaryantdeger;
        }

        public IActionResult Urunler()
        {
            var uruns = _urunservice.UrunListKategiriVeMarkaIle();
            return View(uruns);
        }
        [HttpGet]
        public IActionResult UrunEkle()
        {
            return View();
        }

       
        [HttpPost]
        public async Task<IActionResult> UrunEkle(Urun urun,IFormFile file,List<IFormFile> file2,List<string>d1, List<string> d2)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(_webHost.WebRootPath, "Resimler/UrunResim", fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                urun.UrunResim = fileName;

                if (urun.IndirimSecenegi == (int)IndirimTurleri.IndirimTuru.IndirimOrani)
                {
                    var fiyat =Convert.ToInt32(urun.UrunFiyati);
                    var indirimorani = Convert.ToInt32(urun.IndirimMiktari);
                    var hesapfiyat = Convert.ToInt32((fiyat * indirimorani) / 100);
                    int sonfiyat = fiyat - hesapfiyat;

                    int kdv = Convert.ToInt32(urun.Kdv);
                    float kdvhesapla = (sonfiyat * kdv)/100;
                    float kdvlifiyat = sonfiyat + kdvhesapla;

                    urun.UrunIndirimliFiyati = kdvlifiyat.ToString();
                    urun.IndirimOrani = indirimorani.ToString();

                    foreach (var i in d1)
                    {
                        UrunVaryantDeger uvd = new UrunVaryantDeger
                        {
                            VaryantAdi = "s",
                            UrunId = urun.Id,
                            VaryantDegerAdi = i.ToString(),
                            GroupId = 4
    
                        };
                        _urunvaryantdeger.TAdd(uvd);

                    }
                    foreach (var i in d2)
                    {
                        UrunVaryantDeger uvd = new UrunVaryantDeger
                        {
                            VaryantAdi = "s",
                            UrunId = urun.Id,
                            VaryantDegerAdi = i.ToString(),
                            GroupId = 3

                        };
                        _urunvaryantdeger.TAdd(uvd);
                    }


                    _urunservice.TAdd(urun);

                }
                else if(urun.IndirimSecenegi == (int)IndirimTurleri.IndirimTuru.SabitFiyat)
                {
                    var fiyat = Convert.ToInt32(urun.UrunFiyati);
                    var indirim = Convert.ToInt32(urun.IndirimMiktari);
                    var hesapfiyat = Convert.ToInt32(fiyat - indirim);

					int kdv = Convert.ToInt32(urun.Kdv);
					float kdvhesapla = (hesapfiyat * kdv) / 100;
					float kdvlifiyat = hesapfiyat + kdvhesapla;

					urun.UrunIndirimliFiyati = kdvlifiyat.ToString();
                    urun.IndirimMiktari = indirim.ToString();

                    _urunservice.TAdd(urun);
                }
                else
                {
                    double fiyat = Convert.ToDouble(urun.UrunFiyati);
                    double kdv =Convert.ToDouble(urun.Kdv);
                    double hesap = (fiyat*kdv)/100;
                    double fiyatguncel = fiyat + hesap;

                    urun.UrunFiyati = fiyatguncel.ToString();
                    _urunservice.TAdd(urun);
                    
                }


            }
            foreach (var i in file2)
            {
                if (i != null && i.Length > 0)
                {
                    var fileName2 = Path.GetFileName(i.FileName);
                    var filePath2 = Path.Combine(_webHost.WebRootPath, "Resimler/UrunResim", fileName2);

                    using (var fileStream2 = new FileStream(filePath2, FileMode.Create))
                    {
                        await i.CopyToAsync(fileStream2);
                    }


                    UrunCokluResim resimler = new UrunCokluResim
                    {
                        Urunid = urun.Id,
                        UrunResim = fileName2
                    };

                    _uruncokluresim.TAdd(resimler);
                }
            }

            //foreach(var m in deger1)
            //{
            //    UrunVaryantDeger degers = new UrunVaryantDeger
            //    {
            //        UrunId = urun.Id,
            //        VaryantDegerId = m,
            //        VaryantDegerId2= 0
                    
            //    };
            //    _urunvaryantdeger.TAdd(degers);
            //}

            //foreach (var o in deger2)
            //{
            //    UrunVaryantDeger degers2 = new UrunVaryantDeger
            //    {
            //        UrunId = urun.Id,
            //        VaryantDegerId = 0,
            //        VaryantDegerId2 = o

            //    };
            //    _urunvaryantdeger.TAdd(degers2);


            //}

            TempData["success"] = "işlem başarılı";

          
            return RedirectToAction("UrunEkle","Urun");
        }

        public IActionResult UrunDuzenle(int id)
        {
            return View();
        }
        public IActionResult UrunSil(int id)
        {
            var urun = _urunservice.TGetById(id);
            _urunservice.TDelete(urun);
            return RedirectToAction("Urunler", "Urun");
        }
        public IActionResult UrunAktifYap(int id)
        {
            var urun = _urunservice.TGetById(id);
            urun.UrunDurumu = 1;
            _urunservice.TUpdate(urun);
            return RedirectToAction("Urunler", "Urun");
        }
        public IActionResult UrunPasifYap(int id)
        {
            var urun = _urunservice.TGetById(id);
            urun.UrunDurumu = 0;
            _urunservice.TUpdate(urun);
            return RedirectToAction("Urunler", "Urun");
        }
    }
}
