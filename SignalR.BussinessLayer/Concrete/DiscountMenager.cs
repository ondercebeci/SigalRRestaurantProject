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
    public class DiscountMenager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountMenager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void TAdd(Discount Entity)
        {
            _discountDal.Add(Entity);
        }

        public void TChangeStatusToFalse(int id)
        {
            _discountDal.ChangeStatusToFalse(id);
        }

        public void TChangeStatusToTrue(int id)
        {
            _discountDal.ChangeStatusToTrue(id);
        }

        public void TDelete(Discount Entity)
        {
            _discountDal.Delete(Entity);
        }

        public Discount TGetByID(int id)
        {
            return _discountDal.GetByID(id);
        }

        public List<Discount> TGetListAll()
        {
            return _discountDal.GetListAll();
        }

        public List<Discount> TGetListByStatusTrue()
        {
            return _discountDal.GetListByStatusTrue();
        }

        public void TUpdate(Discount Entity)
        {
            _discountDal.Update(Entity);
        }
    }
}
