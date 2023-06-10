using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class UrunVaryantDeger
    {
        public int Id { get; set; }
        public string? VaryantAdi { get; set; }
        public string? VaryantDegerAdi { get; set; }
        public int? GroupId { get; set; }
        public int? UrunId { get; set; }

        public virtual Urun IdNavigation { get; set; } = null!;
    }
}
