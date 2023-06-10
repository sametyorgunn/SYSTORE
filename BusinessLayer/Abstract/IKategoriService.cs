using BusinessLayer.Abstract.Generic;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IKategoriService:IGenericService<Kategori>
	{
		List<Kategori> KategoriUstKategorisiyleGetir();
		void KategoriVeAltKategorilerylePasifYap(int id);
	}
}
