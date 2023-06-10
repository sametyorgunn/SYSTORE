using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories.Generic;
using EntityLayer.Dtos;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class EfKategoriRepository : EfGenericRepository<Kategori>, IKategoriDal
	{
		

		public List<Kategori> KategoriListesiUstKategoriIle()
		{
			using(SyStoreContext c = new SyStoreContext())
			{
				var kategori = c.Kategoris.ToList();
				List<Kategori> kategoris = new List<Kategori>();
				for (int i = 0; i < 5; i++)
				{
					foreach (var item in kategori)
					{
						var kate = c.Kategoris.Where(x => x.Id == item.Id).FirstOrDefault();
						var ustkat = c.Kategoris.Where(x => x.UstKategoriId == kate.Id).FirstOrDefault();
						if (kategoris.Contains(ustkat) == false)
						{
							kategoris.Add(ustkat);
						}
					}
				}
				return kategoris;

			}
		}

       

        public void KategoriVeAltKategorileriPasifYap(int id)
        {
            using (SyStoreContext c = new SyStoreContext())
            {
				List<Kategori> liste = new List<Kategori>();

				var kategori = c.Kategoris.Find(id);
				liste.Add(kategori);
				var altkategorileri = c.Kategoris.Where(x=>x.UstKategoriId==kategori.Id).ToList();

				
				foreach(var i in altkategorileri)
				{
					liste.Add(i);

					var altinalti = c.Kategoris.Where(x=>x.UstKategoriId==i.Id).ToList();

					foreach(var j in altinalti)
					{
						liste.Add(j);
					}
				}

				foreach(var k in liste)
				{
					k.KategoriDurumu = 0;
					c.SaveChanges();
				}
                

            }
        }
    }
}
