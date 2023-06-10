using BusinessLayer.Abstract;
using EntityLayer.Dtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class KategoriController : Controller
	{
		private readonly IKategoriService _kategoriService;
		private readonly IWebHostEnvironment _WebHost;

		public KategoriController(IKategoriService kategoriService, IWebHostEnvironment webHost)
		{
			_kategoriService = kategoriService;
			_WebHost = webHost;
		}

		public IActionResult Kategoriler()
		{
			var kategoriler = _kategoriService.GetList();
			var kategrilerustkategorisiyle = _kategoriService.KategoriUstKategorisiyleGetir();
			return View(kategoriler);
		}
		[HttpPost]
		public async Task<IActionResult> KategoriEkle(Kategori kategori, IFormFile file)
		{

			if (file != null && file.Length > 0)
			{
				var fileName = Path.GetFileName(file.FileName);
				var filePath = Path.Combine(_WebHost.WebRootPath, "Resimler/KategoriResim", fileName);

				using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					await file.CopyToAsync(fileStream);
				}
				kategori.KategoriResim = fileName;

				_kategoriService.TAdd(kategori);
				return RedirectToAction("Kategoriler", "Kategori");
			}
			return RedirectToAction("Kategoriler", "Kategori");


		}

		public IActionResult KategoriDuzenle(int id)
		{
			var kategori = _kategoriService.TGetById(id);
			return View(kategori);
		}
		[HttpPost]
		public async Task<IActionResult> KategoriDuzenle(KategoriDuzenleDto dto, IFormFile file)
		{
			if (file != null && file.Length > 0)
			{
				var fileName = Path.GetFileName(file.FileName);
				var filePath = Path.Combine(_WebHost.WebRootPath, "Resimler/KategoriResim", fileName);

				using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					await file.CopyToAsync(fileStream);
				}

				Kategori kategori = new Kategori()
				{
					Id = dto.Id,
					KategoriResim = fileName,
					KategoriAdi = dto.KategoriAdi,
					KategoriAciklamasi = dto.KategoriAciklamasi,
					UstKategoriId = dto.UstKategoriId,
					KategoriDurumu = dto.KategoriDurumu

				};

				_kategoriService.TUpdate(kategori);
				return RedirectToAction("Kategoriler", "Kategori");
			}
			else
			{
				var kategors = _kategoriService.TGetById(dto.Id);
				Kategori kategori = new Kategori()
				{
					Id = dto.Id,
					KategoriResim = kategors.KategoriResim,
					KategoriAdi = dto.KategoriAdi,
					UstKategoriId = dto.UstKategoriId,
					KategoriAciklamasi = dto.KategoriAciklamasi,
					KategoriDurumu = dto.KategoriDurumu
				};

				_kategoriService.TUpdate(kategori);
				return RedirectToAction("Kategoriler", "Kategori");
			}
			return RedirectToAction("Kategoriler", "Kategori");

		}

		public IActionResult KategoriSil(int id)
		{
			var kategori = _kategoriService.TGetById(id);
			_kategoriService.TDelete(kategori);
			return RedirectToAction("Kategoriler","Kategori");
		}

		public IActionResult KategoriPasifYap(int id)
		{
			_kategoriService.KategoriVeAltKategorilerylePasifYap(id);
			return RedirectToAction("Kategoriler", "Kategori");

		}
		public IActionResult KategoriAktifYap(int id)
		{
			var kategori = _kategoriService.TGetById(id);
			kategori.KategoriDurumu = 1;
			_kategoriService.TUpdate(kategori);
			return RedirectToAction("Kategoriler", "Kategori");
		}

	}
}
