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
    public class VaryantDegerManager : IVaryantDegerService
    {
        private readonly IVaryantDegerDal _varyantdegerdal;

        public VaryantDegerManager(IVaryantDegerDal varyantdegerdal)
        {
            _varyantdegerdal = varyantdegerdal;
        }

        public List<VaryantDeger> GetList()
        {
            return _varyantdegerdal.GetListAll();
        }

        public List<VaryantDeger> GetListAll(Expression<Func<VaryantDeger, bool>> filter)
        {
            return _varyantdegerdal.GetListAll(filter);
        }

        public void TAdd(VaryantDeger t)
        {
            _varyantdegerdal.Insert(t);
        }

        public void TDelete(VaryantDeger t)
        {
            _varyantdegerdal.Delete(t);
        }

        public VaryantDeger TGetById(int id)
        {
            return _varyantdegerdal.GetById(id);
        }

        public void TUpdate(VaryantDeger t)
        {
            _varyantdegerdal.Update(t);
        }

        public List<VaryantDeger> VaryantGetirDegerleriIle(int id)
        {
            return _varyantdegerdal.VaryantVedegerleriniGetir(id);
        }
    }
}
