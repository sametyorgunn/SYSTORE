using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class Kategori
    {
        public Kategori()
        {
            Uruns = new HashSet<Urun>();
        }

        public int Id { get; set; }
        public string? KategoriAdi { get; set; }
        public string? KategoriAciklamasi { get; set; }
        public int? KategoriDurumu { get; set; }
        public string? KategoriSlug { get; set; }
        public string? KategoriResim { get; set; }
        public int? UstKategoriId { get; set; }

        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
