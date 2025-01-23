using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IMenuTableDal:IGenericDal<MenuTable>
    {
        int MenuTableCount();
        int ActiveMenuTableCount();
        void ChangeMenuTableStatusToFalse(int id);
        void ChangeMenuTableStatusToTrue(int id);
    }
}
