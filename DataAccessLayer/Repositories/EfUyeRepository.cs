using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories.Generic;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class EfUyeRepository : EfGenericRepository<Uye>, IUyeDal
	{
		public Uye UyeLoginControl(Uye uye)
		{
			using (SyStoreContext c = new SyStoreContext())
			{
				var uyelogin = c.Uyes.Where(x => x.KullaniciAdi == uye.KullaniciAdi && x.Sifre == uye.Sifre).FirstOrDefault();
				return uyelogin;
			}
		}
	}
}
