using DataAccessLayer.Abstract.Generic;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IVaryantDegerMapDal:IGenericDal<VaryantDegerMap>
    {
        List<VaryantDegerMap> VaryantVedegerleriniGetir(int id);
    }
}
