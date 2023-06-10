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
	public class VaryantManager : IVaryantService
	{
		private readonly IVaryantDal _varyantdal;

		public VaryantManager(IVaryantDal varyantdal)
		{
			_varyantdal = varyantdal;
		}

		public List<Varyant> GetList()
		{
			return _varyantdal.GetListAll();
		}

		public List<Varyant> GetListAll(Expression<Func<Varyant, bool>> filter)
		{
			return _varyantdal.GetListAll(filter);
		}

		public void TAdd(Varyant t)
		{
			_varyantdal.Insert(t);
		}

		public void TDelete(Varyant t)
		{
			_varyantdal.Delete(t);
		}

		public Varyant TGetById(int id)
		{
			return _varyantdal.GetById(id);	
		}

		public void TUpdate(Varyant t)
		{
			_varyantdal.Update(t);	
		}

        public List<Varyant> VaryantVeDegerGetir()
        {
			return _varyantdal.VaryantDegerGetir();
        }

        public Varyant VaryantVeDegerleriniGetir(int id)
        {
			return _varyantdal.VaryantGetirDegerlerIle(id);
        }
    }
}
