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
    public class MessageMenager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageMenager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message Entity)
        {
            _messageDal.Add(Entity);
        }

        public void TDelete(Message Entity)
        {
            _messageDal.Delete(Entity);
        }

        public Message TGetByID(int id)
        {
            return _messageDal.GetByID(id);
        }

        public List<Message> TGetListAll()
        {
            return _messageDal.GetListAll();
        }

        public void TUpdate(Message Entity)
        {
            _messageDal.Update(Entity);
        }
    }
}
