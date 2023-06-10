using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class Sepet
    {
        public int Id { get; set; }
        public int? UrunId { get; set; }
        public string? Adet { get; set; }
        public int? UyeId { get; set; }
        public int? UyeOlmayanId { get; set; }

        public virtual Urun? Urun { get; set; }
        public virtual Uye? Uye { get; set; }
    }
}
