using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos
{
    public class VaryantDuzenleDto
    {
        public int VaryantId { get; set; }
        public string? VaryantAdi { get; set; }
        public int? VaryantDurumu { get; set; }


        public string? VaryantDegerResim { get; set; }
        public int? VaryantDegerDurumu { get; set; }
        public int? DegerVaryantid { get; set; }
        public List<ADegerDto> DegerlerDizi { get; set; }

        public List<int> silinenDegerIds { get; set; }

    }

    public class ADegerDto
    {
        public int Id { get; set; }
        public string Deger { get; set; }
    }
}
