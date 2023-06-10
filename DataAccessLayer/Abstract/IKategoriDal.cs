using DataAccessLayer.Abstract.Generic;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IKategoriDal:IGenericDal<Kategori>
	{
		List<Kategori> KategoriListesiUstKategoriIle();
		void KategoriVeAltKategorileriPasifYap(int id);
	}
}
