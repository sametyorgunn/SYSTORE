using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class Marka
    {
        public Marka()
        {
            Uruns = new HashSet<Urun>();
        }

        public int Id { get; set; }
        public string? MarkaAdi { get; set; }
        public int? MarkaDurumu { get; set; }

        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
