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
	public class FavoriManager : IFavoriService
	{
		private readonly IFavoriDal _favoridal;

		public FavoriManager(IFavoriDal favoridal)
		{
			_favoridal = favoridal;
		}

		public List<Favori> GetList()
		{
			return _favoridal.GetListAll();
		}

		public List<Favori> GetListAll(Expression<Func<Favori, bool>> filter)
		{
			return _favoridal.GetListAll(filter);
		}

		public void TAdd(Favori t)
		{
			_favoridal.Insert(t);
		}

		public void TDelete(Favori t)
		{
			_favoridal.Delete(t);
		}

		public Favori TGetById(int id)
		{
			return _favoridal.GetById(id);
		}

		public void TUpdate(Favori t)
		{
			_favoridal.Update(t);
		}
	}
}
