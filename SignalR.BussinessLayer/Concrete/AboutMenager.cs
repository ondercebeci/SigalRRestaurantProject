using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntitiLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Concrete
{
	public class AboutMenager : IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutMenager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TAdd(About Entity)
		{
			_aboutDal.Add(Entity);
		}

		public void TDelete(About Entity)
		{
			_aboutDal.Delete(Entity);
		}

		public About TGetByID(int id)
		{
			return _aboutDal.GetByID(id);
		}

		public List<About> TGetListAll()
		{
			return _aboutDal.GetListAll();
		}

		public void TUpdate(About Entity)
		{
			_aboutDal.Update(Entity);
		}
	}
}
