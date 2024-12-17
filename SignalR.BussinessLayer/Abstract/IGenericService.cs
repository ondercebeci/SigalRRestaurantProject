using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void TAdd(T Entity);
		void TDelete(T Entity);
		void TUpdate(T Entity);
		T TGetByID(int id);
		List<T> TGetListAll();
	}
}
