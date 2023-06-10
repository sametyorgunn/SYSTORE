using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class VaryantDegerMap
    {
        public int Id { get; set; }
        public int? VaryantId { get; set; }
        public int? VaryantDegerId { get; set; }

        public virtual Varyant? Varyant { get; set; }
        public virtual VaryantDeger? VaryantDeger { get; set; }
    }
}
