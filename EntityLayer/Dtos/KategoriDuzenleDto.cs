using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos
{
	public class KategoriDuzenleDto
	{
		public int Id { get;set; }
		public string? KategoriAdi { get; set; }
		public string? KategoriAciklamasi { get; set; }
		public int UstKategoriId { get; set; }
		public int? KategoriDurumu { get; set; }
		public string? KategoriSlug { get; set; }
		public string? KategoriResim { get; set; }
		public IFormFile Resim { get; set; }
	}
}
