using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class Urun
    {
        public Urun()
        {
            Favoris = new HashSet<Favori>();
            Sepets = new HashSet<Sepet>();
            UrunCokluResims = new HashSet<UrunCokluResim>();
        }

        public int Id { get; set; }
        public string? UrunAdi { get; set; }
        public string? UrunAciklamasi { get; set; }
        public string? UrunFiyati { get; set; }
        public string? UrunIndirimliFiyati { get; set; }
        public int? UrunDurumu { get; set; }
        public string? UrunResim { get; set; }
        public int KategoriId { get; set; }
        public string? BarkodNo { get; set; }
        public string? Stok { get; set; }
        public int? MarkaId { get; set; }
        public int? AnasayfadaGoster { get; set; }
        public int? IndirimliUrunlerdeGoster { get; set; }
        public int? UcretsizKargo { get; set; }
        public int? IndirimSecenegi { get; set; }
        public string? IndirimMiktari { get; set; }
        public string? IndirimOrani { get; set; }
        public string? SabitFiyat { get; set; }
        public string? Kdv { get; set; }

        public virtual Kategori Kategori { get; set; } = null!;
        public virtual Marka? Marka { get; set; }
        public virtual ICollection<Favori> Favoris { get; set; }
        public virtual ICollection<Sepet> Sepets { get; set; }
        public virtual ICollection<UrunCokluResim> UrunCokluResims { get; set; }
    }
}
