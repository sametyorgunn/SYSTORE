using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories.Generic;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EfSiparisRepository : EfGenericRepository<Sipari>, ISiparisDal
    {
        public List<Sipari> SiparisUyeBilgileriGetir()
        {
            using(SyStoreContext c = new SyStoreContext())
            {
                var siparisler = c.Siparis.Include(x => x.Uye).ToList();
                return siparisler;
            }
        }
    }
}
