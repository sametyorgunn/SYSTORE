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
	public class UrunManager : IUrunService
	{
		private readonly IUrunDal _urundal;

		public UrunManager(IUrunDal urundal)
		{
			_urundal = urundal;
		}

		public List<Urun> GetList()
		{
			return _urundal.GetListAll();
		}

		public List<Urun> GetListAll(Expression<Func<Urun, bool>> filter)
		{
			return _urundal.GetListAll(filter);
		}

		public void TAdd(Urun t)
		{
			_urundal.Insert(t);
		}

		public void TDelete(Urun t)
		{
			_urundal.Delete(t);
		}

		public Urun TGetById(int id)
		{
			return _urundal.GetById(id);
		}

		public void TUpdate(Urun t)
		{
			_urundal.Update(t);
		}

        public List<Urun> UrunListKategiriVeMarkaIle()
        {
			return _urundal.UrunleriMarkaVeKategorisiyleGetir();
        }

        public List<Urun> UrunListesiGetirKategoriyeGore(int id)
        {
	        return _urundal.UrunListesiKategoriyeGore(id);
        }

        public List<Urun> UrunListKategorisiIle()
		{
			return _urundal.UrunListesiKategoriyle();
		}
	}
}
