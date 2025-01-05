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
    public class BasketMenager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketMenager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TAdd(Basket Entity)
        {
            _basketDal.Add(Entity);
        }

        public void TDelete(Basket Entity)
        {
            _basketDal.Delete(Entity);
        }

        public List<Basket> TGetBasketByMenuTableNumber(int id)
        {
            return _basketDal.GetBasketByMenuTableNumber(id);
        }

        public Basket TGetByID(int id)
        {
            return _basketDal.GetByID(id);
        }

        public List<Basket> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Basket Entity)
        {
            throw new NotImplementedException();
        }
    }
}
