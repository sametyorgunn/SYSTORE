using BusinessLayer.Abstract.Generic;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ISiparisService:IGenericService<Sipari>
	{
		public List<Sipari> SiparisUyeBilgileriTopluGetir();
	}
}
