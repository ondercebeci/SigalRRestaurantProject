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
    public class ContactMenager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactMenager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact Entity)
        {
            _contactDal.Add(Entity);
        }

        public void TDelete(Contact Entity)
        {
            _contactDal.Delete(Entity);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void TUpdate(Contact Entity)
        {
            _contactDal.Update(Entity);
        }
    }
}
