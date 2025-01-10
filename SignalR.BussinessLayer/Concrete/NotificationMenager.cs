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
    public class NotificationMenager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationMenager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TAdd(Notification Entity)
        {
            _notificationDal.Add(Entity);
        }

        public void TDelete(Notification Entity)
        {
            _notificationDal.Delete(Entity);
        }

        public List<Notification> TGetAllNotificationByFalse()
        {
            return _notificationDal.GetAllNotificationByFalse();
        }

        public Notification TGetByID(int id)
        {
            return _notificationDal.GetByID(id);
        }

        public List<Notification> TGetListAll()
        {
            return _notificationDal.GetListAll();
        }

        public int TNotificationCountByStatusFalse()
        {
            return _notificationDal.NotificationCountByStatusFalse();
        }

        public void TNotificationStatusChangeToFalse(int id)
        {
            _notificationDal.NotificationStatusChangeToFalse(id);
        }

        public void TNotificationStatusChangeToTrue(int id)
        {
            _notificationDal.NotificationStatusChangeToTrue(id);
        }

        public void TUpdate(Notification Entity)
        {
            _notificationDal.Update(Entity);
        }
    }
}
