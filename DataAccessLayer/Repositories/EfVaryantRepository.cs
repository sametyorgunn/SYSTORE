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
    public class EfVaryantRepository : EfGenericRepository<Varyant>, IVaryantDal
    {
        public List<Varyant> VaryantDegerGetir()
        {
            using(SyStoreContext c = new SyStoreContext())
            {
                var varyantlar = c.Varyants.Include(x => x.VaryantDegers).ToList();
                return varyantlar;
            }
        }

        public Varyant VaryantGetirDegerlerIle(int id)
        {
            using(SyStoreContext c = new SyStoreContext())
            {
                var varyants = c.Varyants.Where(x => x.Id == id).Include(x => x.VaryantDegers).FirstOrDefault();
                return varyants;
            }
        }
    }
}
