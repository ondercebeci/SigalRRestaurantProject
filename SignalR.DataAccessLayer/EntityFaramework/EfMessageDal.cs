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
    public class EfMessageDal:GenericRepository<Message>,IMessageDal
    {
        public EfMessageDal(SignalRContext contex):base(contex)
        {
            
        }
    }
}
