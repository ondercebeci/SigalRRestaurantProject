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
    public class TestimonialMenager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialMenager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial Entity)
        {
            _testimonialDal.Add(Entity);
        }

        public void TDelete(Testimonial Entity)
        {
            _testimonialDal.Delete(Entity);
        }

        public Testimonial TGetByID(int id)
        {
           return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonialDal.GetListAll();
        }

        public void TUpdate(Testimonial Entity)
        {
            _testimonialDal.Update(Entity);
        }
    }
}
