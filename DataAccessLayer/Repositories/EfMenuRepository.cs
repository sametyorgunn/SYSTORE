using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories.Generic;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class EfMenuRepository:EfGenericRepository<Menu>,IMenuDal
	{
	}
}
