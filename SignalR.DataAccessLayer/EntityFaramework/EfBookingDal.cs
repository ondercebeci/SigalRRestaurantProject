using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Conctrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFaramework
{
	public class EfBookingDal : GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(SignalRContext context) : base(context)
		{
		}

        public void BookingStatusApproved(int id)
        {
            SignalRContext context = new SignalRContext();
            var values = context.Bookings.Find(id);
             values.Description = "Rezervasyon Onaylandı";
            context.SaveChanges();
            
        }

        public void BookingStatusCancelled(int id)
        {
            SignalRContext context = new SignalRContext();
            var values = context.Bookings.Find(id);
            values.Description = "Rezervasyon İptal Edildi";
            context.SaveChanges();
        }
    }
}
