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
	public class EfUrunRepository : EfGenericRepository<Urun>, IUrunDal
	{
        public List<Urun> UrunleriMarkaVeKategorisiyleGetir()
        {
            using (SyStoreContext c = new SyStoreContext())
            {
                var uruns = c.Uruns.Include(x => x.Kategori).Include(y=>y.Marka).ToList();
                return uruns;
            }
        }

        public List<Urun> UrunListesiKategoriyeGore(int id)
        {
	        using (SyStoreContext c = new SyStoreContext())
	        {
		        var uruns = c.Uruns.Where(x => x.KategoriId == id && x.UrunDurumu==1).ToList();
		        return uruns;
	        }
        }

        public List<Urun> UrunListesiKategoriyle()
		{
			using(SyStoreContext c = new SyStoreContext())
			{
				var uruns = c.Uruns.Include(x => x.Kategori).Where(x => x.UrunDurumu == 1).ToList();
				return uruns;
			}
		}
	}
}
