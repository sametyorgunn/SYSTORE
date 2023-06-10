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
    public class UrunCokluResimManager : IUrunCokluResimService
    {
        private readonly IUrunCokluResimDal _uruncokluresimdal;

        public UrunCokluResimManager(IUrunCokluResimDal uruncokluresimdal)
        {
            _uruncokluresimdal = uruncokluresimdal;
        }

        public List<UrunCokluResim> GetList()
        {
            return _uruncokluresimdal.GetListAll();
        }

        public List<UrunCokluResim> GetListAll(Expression<Func<UrunCokluResim, bool>> filter)
        {
            return _uruncokluresimdal.GetListAll(filter);
        }

        public void TAdd(UrunCokluResim t)
        {
            _uruncokluresimdal.Insert(t);
        }

        public void TDelete(UrunCokluResim t)
        {
            _uruncokluresimdal.Delete(t);
        }

        public UrunCokluResim TGetById(int id)
        {
            return _uruncokluresimdal.GetById(id);
        }

        public void TUpdate(UrunCokluResim t)
        {
            throw new NotImplementedException();
        }
    }
}
