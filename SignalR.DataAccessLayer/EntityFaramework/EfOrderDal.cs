using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Conctrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFaramework
{
    public class EfOrderDal:GenericRepository<Order>,IOrderDal
    {
        public EfOrderDal(SignalRContext context):base(context)
        {
            
        }

        public int ActiveOrderCount()
        {
            SignalRContext context = new SignalRContext();
            return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            SignalRContext context = new SignalRContext();
            return context.Orders.OrderByDescending(x => x.OrderID).Select(y => y.TotalPrice).FirstOrDefault();
        }

        public int TotalOrderCount()
        {
            SignalRContext context = new SignalRContext();
            return context.Orders.Count();
        }
    }
}
