using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class UrunCokluResim
    {
        public int Id { get; set; }
        public string? UrunResim { get; set; }
        public int? Urunid { get; set; }

        public virtual Urun? Urun { get; set; }
    }
}
