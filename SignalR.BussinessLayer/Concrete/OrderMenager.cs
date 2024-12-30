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
    public class OrderMenager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderMenager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public int TActiveOrderCount()
        {
          return  _orderDal.ActiveOrderCount();
        }

        public void TAdd(Order Entity)
        {
            _orderDal.Add(Entity);
        }

        public void TDelete(Order Entity)
        {
            _orderDal.Add(Entity);
        }

        public Order TGetByID(int id)
        {
            return _orderDal.GetByID(id);
        }

        public List<Order> TGetListAll()
        {
            return _orderDal.GetListAll();
        }

        public decimal TLastOrderPrice()
        {
            return _orderDal.LastOrderPrice();
        }

        public decimal TodayTotalPrice()
        {
            return _orderDal.TodayTotalPrice();
        }

        public decimal TTodayTotalPrice()
        {
            return _orderDal.TodayTotalPrice();
        }

        public int TTotalOrderCount()
        {
            return _orderDal.TotalOrderCount();
        }

        public void TUpdate(Order Entity)
        {
            _orderDal.Add(Entity);
        }
    }
}
