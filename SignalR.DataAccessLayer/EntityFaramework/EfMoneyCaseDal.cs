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
    public class EfMoneyCaseDal:GenericRepository<MoneyCase>,IMoneyCaseDal
    {
        public EfMoneyCaseDal(SignalRContext context):base(context)
        {
            
        }

        public decimal TotalMoneyCaseAmount()
        {
            SignalRContext context = new SignalRContext();
            return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}
