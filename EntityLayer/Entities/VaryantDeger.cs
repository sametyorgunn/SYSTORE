using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class VaryantDeger
    {
        public VaryantDeger()
        {
            VaryantDegerMaps = new HashSet<VaryantDegerMap>();
        }

        public int Id { get; set; }
        public string? VaryantDegerAdi { get; set; }
        public string? VaryantDegerResim { get; set; }
        public int? VaryantDegerDurumu { get; set; }
        public int? Varyantid { get; set; }

        public virtual Varyant? Varyant { get; set; }
        public virtual ICollection<VaryantDegerMap> VaryantDegerMaps { get; set; }
    }
}
