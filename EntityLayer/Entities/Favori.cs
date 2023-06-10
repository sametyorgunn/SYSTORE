using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class Favori
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public int UyeId { get; set; }

        public virtual Urun Urun { get; set; } = null!;
        public virtual Uye Uye { get; set; } = null!;
    }
}
