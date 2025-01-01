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
    public class EfMenuTableDal:GenericRepository<MenuTable>,IMenuTableDal
    {
        public EfMenuTableDal(SignalRContext context):base(context)
        {
            
        }

        public int ActiveMenuTableCount()
        {
            SignalRContext context = new SignalRContext();
            return context.MenuTables.Count(x => x.Status == true);
        }

        public int MenuTableCount()
        {
            SignalRContext context = new SignalRContext();

            return context.MenuTables.Count();
        }
    }
}
