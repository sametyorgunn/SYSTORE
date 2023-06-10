using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class SepetUyeMap
    {
        public int Id { get; set; }
        public int SepetId { get; set; }
        public int UyeId { get; set; }

        public virtual Uye Uye { get; set; } = null!;
    }
}
