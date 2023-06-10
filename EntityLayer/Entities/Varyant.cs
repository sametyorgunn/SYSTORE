using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class Varyant
    {
        public Varyant()
        {
            VaryantDegerMaps = new HashSet<VaryantDegerMap>();
            VaryantDegers = new HashSet<VaryantDeger>();
        }

        public int Id { get; set; }
        public string? VaryantAdi { get; set; }
        public int? VaryantDurumu { get; set; }

        public virtual ICollection<VaryantDegerMap> VaryantDegerMaps { get; set; }
        public virtual ICollection<VaryantDeger> VaryantDegers { get; set; }
    }
}
