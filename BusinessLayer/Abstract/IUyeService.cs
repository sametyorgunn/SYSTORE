using BusinessLayer.Abstract.Generic;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IUyeService:IGenericService<Uye>
	{
		Uye UyeLoginKontrol(Uye uye);
	}
}
