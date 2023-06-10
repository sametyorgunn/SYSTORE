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
	public class SiparisManager : ISiparisService
	{
		private readonly ISiparisDal _siparisdal;

		public SiparisManager(ISiparisDal siparisdal)
		{
			_siparisdal = siparisdal;
		}

		public List<Sipari> GetList()
		{
			return _siparisdal.GetListAll();
		}

		public List<Sipari> GetListAll(Expression<Func<Sipari, bool>> filter)
		{
			return _siparisdal.GetListAll(filter);
		}

        public List<Sipari> SiparisUyeBilgileriTopluGetir()
        {
            return _siparisdal.SiparisUyeBilgileriGetir();
        }

        public void TAdd(Sipari t)
		{
			_siparisdal.Insert(t);
		}

		public void TDelete(Sipari t)
		{
			_siparisdal.Delete(t);
		}

		public Sipari TGetById(int id)
		{
			return _siparisdal.GetById(id);
		}

		public void TUpdate(Sipari t)
		{
			_siparisdal.Update(t);
		}
	}
}
