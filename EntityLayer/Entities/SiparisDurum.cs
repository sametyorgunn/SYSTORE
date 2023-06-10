using System;
using System.Collections.Generic;

namespace EntityLayer.Entities
{
    public partial class SiparisDurum
    {
        public SiparisDurum()
        {
            Siparis = new HashSet<Sipari>();
        }

        public int Id { get; set; }
        public string? SiparisDurum1 { get; set; }

        public virtual ICollection<Sipari> Siparis { get; set; }
    }
}
