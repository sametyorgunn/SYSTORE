using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class Sipari
    {
        public int Id { get; set; }
        public int? UyeId { get; set; }
        public int? SepetId { get; set; }
        public string? SiparisTarih { get; set; }
        public string? SiparisNo { get; set; }
        public string? AdSoyad { get; set; }
        public string? MailAdresi { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public string? ToplamFiyat { get; set; }

        public virtual Uye? Uye { get; set; }
    }
}
