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
    public class EfVaryantDegerMapRepository : EfGenericRepository<VaryantDegerMap>, IVaryantDegerMapDal
    {
        public List<VaryantDegerMap> VaryantVedegerleriniGetir(int id)
        {
            using(SyStoreContext c =new SyStoreContext())
            {
                var varyant = c.VaryantDegerMaps.Include(x=>x.Varyant).Include(y=>y.VaryantDeger).Where(x=>x.Varyant.Id==x.VaryantId).ToList();
                return varyant;
            }
        }
    }
}
