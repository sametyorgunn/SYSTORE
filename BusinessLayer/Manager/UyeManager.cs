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
	public class UyeManager : IUyeService
	{
		private readonly IUyeDal _uyedal;

		public UyeManager(IUyeDal uyedal)
		{
			_uyedal = uyedal;
		}

		public List<Uye> GetList()
		{
			return _uyedal.GetListAll();
		}

		public List<Uye> GetListAll(Expression<Func<Uye, bool>> filter)
		{
			return _uyedal.GetListAll(filter);
		}

		public void TAdd(Uye t)
		{
			_uyedal.Insert(t);
		}

		public void TDelete(Uye t)
		{
			_uyedal.Delete(t);
		}

		public Uye TGetById(int id)
		{
			return _uyedal.GetById(id);
		}

		public void TUpdate(Uye t)
		{
			_uyedal.Update(t);
		}

		public Uye UyeLoginKontrol(Uye uye)
		{
			return _uyedal.UyeLoginControl(uye);
		}
	}
}
