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
	public class BookingMenager : IBookingService
	{
		private readonly IBookingDal _bookingDal;

		public BookingMenager(IBookingDal bookingDal)
		{
			_bookingDal = bookingDal;
		}

		public void TAdd(Booking Entity)
		{
			_bookingDal.Add(Entity);
		}

        public void TBookingStatusApproved(int id)
        {
			_bookingDal.BookingStatusApproved(id);
        }

        public void TBookingStatusCancelled(int id)
        {
			_bookingDal.BookingStatusCancelled(id);
        }

        public void TDelete(Booking Entity)
		{
			_bookingDal.Delete(Entity);
		}

		public Booking TGetByID(int id)
		{
			return _bookingDal.GetByID(id);
		}

		public List<Booking> TGetListAll()
		{
			return _bookingDal.GetListAll();
		}

		public void TUpdate(Booking Entity)
		{
			_bookingDal.Update(Entity);
		}
	}
}
