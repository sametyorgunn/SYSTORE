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
	public class SepetManager : ISepetService
	{
		private readonly ISepetDal _sepetdal;

		public SepetManager(ISepetDal sepetdal)
		{
			_sepetdal = sepetdal;
		}

		public List<Sepet> GetList()
		{
			return _sepetdal.GetListAll();
		}

		public List<Sepet> GetListAll(Expression<Func<Sepet, bool>> filter)
		{
			return _sepetdal.GetListAll(filter);
		}

		public void TAdd(Sepet t)
		{
			_sepetdal.Insert(t);
		}

		public void TDelete(Sepet t)
		{
			_sepetdal.Delete(t);	
		}

		public Sepet TGetById(int id)
		{
			return _sepetdal.GetById(id);
		}

		public void TUpdate(Sepet t)
		{
			_sepetdal.Update(t);
		}
	}
}
