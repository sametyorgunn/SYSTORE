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
    public class UrunVaryantDegerManager : IUrunVaryantDegerService
    {
        private readonly IUrunVaryantDegerDal _urunvaryantdegerdal;

        public UrunVaryantDegerManager(IUrunVaryantDegerDal urunvaryantdegerdal)
        {
            _urunvaryantdegerdal = urunvaryantdegerdal;
        }

        public List<UrunVaryantDeger> GetList()
        {
            return _urunvaryantdegerdal.GetListAll();
        }

        public List<UrunVaryantDeger> GetListAll(Expression<Func<UrunVaryantDeger, bool>> filter)
        {
            return _urunvaryantdegerdal.GetListAll(filter);
        }

        public void TAdd(UrunVaryantDeger t)
        {
            _urunvaryantdegerdal.Insert(t);
        }

        public void TDelete(UrunVaryantDeger t)
        {
            _urunvaryantdegerdal.Delete(t);
        }

        public UrunVaryantDeger TGetById(int id)
        {
            return _urunvaryantdegerdal.GetById(id);    
        }

        public void TUpdate(UrunVaryantDeger t)
        {
            _urunvaryantdegerdal.Update(t);
        }
    }
}
