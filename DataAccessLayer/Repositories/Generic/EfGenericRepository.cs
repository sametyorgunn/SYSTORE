using DataAccessLayer.Abstract.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Generic
{
	public class EfGenericRepository<T> : IGenericDal<T> where T : class
	{
		public void Delete(T t)
		{
			using (SyStoreContext c = new SyStoreContext())
			{
				c.Remove(t);
				c.SaveChanges();
			}
		}

		public T GetById(int id)
		{
			using (SyStoreContext c = new SyStoreContext())
			{
				return c.Set<T>().Find(id);
			}
		}

		public List<T> GetListAll()
		{
			using (SyStoreContext c = new SyStoreContext())
			{
				return c.Set<T>().ToList();
			}
		}

		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
			using (SyStoreContext c = new SyStoreContext())
			{				
				return c.Set<T>().Where(filter).ToList();
			}
		}

		public void Insert(T t)
		{
			using (SyStoreContext c = new SyStoreContext())
			{
				c.Add(t);
				c.SaveChanges();
			}
		}

		public void Update(T t)
		{
			using (SyStoreContext c = new SyStoreContext())
			{
				c.Update(t);
				c.SaveChanges();
			}
		}
	}
}
