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
    public class MarkaManager : IMarkaService
    {
        private readonly IMarkaDal _markadal;

        public MarkaManager(IMarkaDal markadal)
        {
            _markadal = markadal;
        }

        public List<Marka> GetList()
        {
            return _markadal.GetListAll();
        }

        public List<Marka> GetListAll(Expression<Func<Marka, bool>> filter)
        {
            return _markadal.GetListAll(filter);
        }

        public void TAdd(Marka t)
        {
            _markadal.Insert(t);
        }

        public void TDelete(Marka t)
        {
            _markadal.Delete(t);    
        }

        public Marka TGetById(int id)
        {
            return _markadal.GetById(id);
        }

        public void TUpdate(Marka t)
        {
           _markadal.Update(t);
        }
    }
}
