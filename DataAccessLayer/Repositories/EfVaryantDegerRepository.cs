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
    public class EfVaryantDegerRepository : EfGenericRepository<VaryantDeger>, IVaryantDegerDal
    {
        public List<VaryantDeger> VaryantVedegerleriniGetir(int id)
        {
            using(SyStoreContext c =new SyStoreContext())
            {
                var varyants = c.VaryantDegers.Include(x=>x.Varyant).Where(x=>x.Varyantid == id).ToList();
                return varyants;
            }
        }
    }
}
