using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
	public class KategoriManager : IKategoriService
	{
		private readonly IKategoriDal _kategoridal;

		public KategoriManager(IKategoriDal kategoridal)
		{
			_kategoridal = kategoridal;
		}

		public List<Kategori> GetList()
		{
			return _kategoridal.GetListAll();
		}

		public List<Kategori> GetListAll(Expression<Func<Kategori, bool>> filter)
		{
			return _kategoridal.GetListAll(filter);
		}


		public List<Kategori> KategoriUstKategorisiyleGetir()
		{
			return _kategoridal.KategoriListesiUstKategoriIle();
		}

      
        public void KategoriVeAltKategorilerylePasifYap(int id)
        {
		  _kategoridal.KategoriVeAltKategorileriPasifYap(id);
        }

        public void TAdd(Kategori t)
		{
			_kategoridal.Insert(t);
		}

		public void TDelete(Kategori t)
		{
			_kategoridal.Delete(t);
		}

		public Kategori TGetById(int id)
		{
			return _kategoridal.GetById(id);
		}

		public void TUpdate(Kategori t)
		{
			_kategoridal.Update(t);
		}
	}
}
