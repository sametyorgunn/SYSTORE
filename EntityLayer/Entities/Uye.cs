using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class Uye
    {
        public Uye()
        {
            Favoris = new HashSet<Favori>();
            SepetUyeMaps = new HashSet<SepetUyeMap>();
            Sepets = new HashSet<Sepet>();
            Siparis = new HashSet<Sipari>();
        }

        public int Id { get; set; }
        public string? Isim { get; set; }
        public string? SoyIsim { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Mail { get; set; }
        public string? Telefon { get; set; }
        public string? Sifre { get; set; }
        public string? UyeResim { get; set; }
        public int? Durum { get; set; }

        public virtual ICollection<Favori> Favoris { get; set; }
        public virtual ICollection<SepetUyeMap> SepetUyeMaps { get; set; }
        public virtual ICollection<Sepet> Sepets { get; set; }
        public virtual ICollection<Sipari> Siparis { get; set; }
    }
}
