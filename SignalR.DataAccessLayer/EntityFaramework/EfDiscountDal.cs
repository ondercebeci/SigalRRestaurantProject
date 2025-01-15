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
	public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
	{
		public EfDiscountDal(SignalRContext context) : base(context)
		{
		}

        public void ChangeStatusToFalse(int id)
        {
            SignalRContext context = new SignalRContext();
            var value = context.Discounts.Find(id);
            value.status = false;
            context.SaveChanges();
        }

        public void ChangeStatusToTrue(int id)
        {
            SignalRContext context = new SignalRContext();
            var value = context.Discounts.Find(id);
            value.status = true;
            context.SaveChanges();
        }

        public List<Discount> GetListByStatusTrue()
        {
            SignalRContext context = new SignalRContext();
            var values = context.Discounts.Where(x => x.status == true).ToList();
            return values;
        }
    }
}
