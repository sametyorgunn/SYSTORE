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
    public class VaryantDegerMapManager : IVaryantDegerMapService
    {
        private readonly IVaryantDegerMapDal _varyantdegermapdal;

        public VaryantDegerMapManager(IVaryantDegerMapDal varyantdegermapdal)
        {
            _varyantdegermapdal = varyantdegermapdal;
        }

        public List<VaryantDegerMap> GetList()
        {
            return _varyantdegermapdal.GetListAll();
            
        }

        public List<VaryantDegerMap> GetListAll(Expression<Func<VaryantDegerMap, bool>> filter)
        {
            return _varyantdegermapdal.GetListAll(filter);
        }

        public void TAdd(VaryantDegerMap t)
        {
            _varyantdegermapdal.Insert(t);
        }

        public void TDelete(VaryantDegerMap t)
        {
            _varyantdegermapdal.Delete(t);
        }

        public VaryantDegerMap TGetById(int id)
        {
            return _varyantdegermapdal.GetById(id);
        }

        public void TUpdate(VaryantDegerMap t)
        {
            _varyantdegermapdal.Update(t);
        }

        public List<VaryantDegerMap> VaryantVeDegerleriniGetirr(int id)
        {
            return _varyantdegermapdal.VaryantVedegerleriniGetir(id);
        }
    }
}
