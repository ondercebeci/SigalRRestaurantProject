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

        public int TActiveMenuTableCount()
        {
            return _menuTableDal.ActiveMenuTableCount();
        }

        public void TAdd(MenuTable Entity)
        {
            _menuTableDal.Add(Entity);
        }

        public void TDelete(MenuTable Entity)
        {
            _menuTableDal.Delete(Entity);
        }

        public MenuTable TGetByID(int id)
        {
            return _menuTableDal.GetByID(id);
        }

        public List<MenuTable> TGetListAll()
        {
          return  _menuTableDal.GetListAll();
        }

        public int TMenuTableCount()
        {
            return _menuTableDal.MenuTableCount();
        }

        public void TUpdate(MenuTable Entity)
        {
            _menuTableDal.Update(Entity);
        }
    }
}
