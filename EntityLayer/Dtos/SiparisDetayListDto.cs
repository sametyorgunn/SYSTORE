using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos
{
	public class SiparisDetayListDto
	{
		public int? UyeId { get; set; }
		public int? SepetId { get; set; }
		public string? SiparisTarih { get; set; }
		public string? SiparisNo { get; set; }
		public string? AdSoyad { get; set; }
		public string? MailAdresi { get; set; }
		public string? Telefon { get; set; }
		public string? Adres { get; set; }
		public int? SiparisDurumuId { get; set; }

		List<Sepet> SepetBilgileri { get; set; }
		List<Uye> UyeBilgileri { get; set; }
		List<Urun> UrunBilgiler { get; set; }


	}
}
