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
	public class SepetUyeMapManager : ISepetUyeMapService
	{
		private readonly ISepetUyeMapDal _sepetuyemapdal;

		public SepetUyeMapManager(ISepetUyeMapDal sepetuyemapdal)
		{
			_sepetuyemapdal = sepetuyemapdal;
		}

		public List<SepetUyeMap> GetList()
		{
			return _sepetuyemapdal.GetListAll();
		}

		public List<SepetUyeMap> GetListAll(Expression<Func<SepetUyeMap, bool>> filter)
		{
			return _sepetuyemapdal.GetListAll(filter);
		}

		public void TAdd(SepetUyeMap t)
		{
			_sepetuyemapdal.Insert(t);
		}

		public void TDelete(SepetUyeMap t)
		{
			_sepetuyemapdal.Delete(t);
		}

		public SepetUyeMap TGetById(int id)
		{
			return _sepetuyemapdal.GetById(id);
		}

		public void TUpdate(SepetUyeMap t)
		{
			_sepetuyemapdal.Update(t);
		}
	}
}
