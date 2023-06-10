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
	public class MenuManager : IMenuService
	{
		private readonly IMenuDal _menudal;

		
		public MenuManager(IMenuDal menudal)
		{
			_menudal = menudal;
		}

		public List<Menu> GetList()
		{
			return _menudal.GetListAll();
		}

		public List<Menu> GetListAll(Expression<Func<Menu, bool>> filter)
		{
			return _menudal.GetListAll(filter);
		}

		public void TAdd(Menu t)
		{
			_menudal.Insert(t);
		}

		public void TDelete(Menu t)
		{
			_menudal.Delete(t);
		}

		public Menu TGetById(int id)
		{
			return _menudal.GetById(id);
		}

		public void TUpdate(Menu t)
		{
			_menudal.Update(t);
		}
	}
}
