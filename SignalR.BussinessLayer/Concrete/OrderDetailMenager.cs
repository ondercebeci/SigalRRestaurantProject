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
    public class OrderDetailMenager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailMenager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }
        public void TAdd(OrderDetail Entity)
        {
            _orderDetailDal.Add(Entity);
        }

        public void TDelete(OrderDetail Entity)
        {
            _orderDetailDal.Delete(Entity);
        }

        public OrderDetail TGetByID(int id)
        {
            return _orderDetailDal.GetByID(id);
        }

        public List<OrderDetail> TGetListAll()
        {
            return _orderDetailDal.GetListAll();
        }

        public void TUpdate(OrderDetail Entity)
        {
            _orderDetailDal.Update(Entity);
        }
    }
}
