using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Concrete
{
    
    public class MenuTableMenager : IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;

        public MenuTableMenager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }

        public void TAdd(MenuTable Entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MenuTable Entity)
        {
            throw new NotImplementedException();
        }

        public MenuTable TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MenuTable> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public int TMenuTableCount()
        {
            return _menuTableDal.MenuTableCount();
        }

        public void TUpdate(MenuTable Entity)
        {
            throw new NotImplementedException();
        }
    }
}
