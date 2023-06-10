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
	public class RolManager : IRolService
	{
		private readonly IRolDal _roldal;

		public RolManager(IRolDal roldal)
		{
			_roldal = roldal;
		}

		public List<Rol> GetList()
		{
			return _roldal.GetListAll();
		}

		public List<Rol> GetListAll(Expression<Func<Rol, bool>> filter)
		{
			return _roldal.GetListAll(filter);
		}

		public void TAdd(Rol t)
		{
			_roldal.Insert(t);
		}

		public void TDelete(Rol t)
		{
			_roldal.Delete(t);
		}

		public Rol TGetById(int id)
		{
			return _roldal.GetById(id);
		}

		public void TUpdate(Rol t)
		{
			_roldal.Update(t);
		}
	}
}
