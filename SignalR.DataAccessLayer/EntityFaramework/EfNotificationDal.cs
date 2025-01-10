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
    public class EfNotificationDal:GenericRepository<Notification>,INotificationDal

    {
        public EfNotificationDal(SignalRContext context):base(context)
        {
            
        }

        public List<Notification> GetAllNotificationByFalse()
        {
            SignalRContext context = new SignalRContext();
            return context.Notifications.Where(x => x.Status == false).ToList();
            
        }

        public int NotificationCountByStatusFalse()
        {
            SignalRContext context = new SignalRContext();

            return context.Notifications.Count(x => x.Status == false);
            

        }

        public void NotificationStatusChangeToFalse(int id)
        {
            SignalRContext context = new SignalRContext();
            var value = context.Notifications.Find(id);
            value.Status = false;
            context.SaveChanges();
        }

        public void NotificationStatusChangeToTrue(int id)
        {
            SignalRContext context = new SignalRContext();
            var value = context.Notifications.Find(id);
            value.Status = true;
            context.SaveChanges();

        }
    }
}
