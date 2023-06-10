using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Enums
{
    public class SiparisDurumlari
    {
        public enum siparisTur
        {
            OdemeBekliyor = 1,
            OdemeAlindi = 2,
            SiparisAlindi = 3,
            SiparisHazirlaniyor = 4,
            KargoyaVerildi = 5,
            SiparisTeslimEdildi = 6
        }
    }
}
