using DataAccessLayer.Abstract.Generic;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IUrunDal:IGenericDal<Urun>
	{
		List<Urun> UrunListesiKategoriyeGore(int id);
		List<Urun> UrunListesiKategoriyle();
		List<Urun> UrunleriMarkaVeKategorisiyleGetir();
	}
}
