using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos
{
    public class VaryantEkleDto
    {
        public string? VaryantAdi { get; set; }
        public int? VaryantDurumu { get; set; }

        public List<string> VaryantDegerAdi { get; set; }
        public string? VaryantDegerResim { get; set; }
        public int? VaryantDegerDurumu { get; set; }
    }
}
