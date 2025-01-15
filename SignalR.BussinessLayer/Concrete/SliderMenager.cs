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
   
    public class SliderMenager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderMenager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider Entity)
        {
            _sliderDal.Add(Entity);
        }

        public void TDelete(Slider Entity)
        {
            _sliderDal.Delete(Entity);
        }

        public Slider TGetByID(int id)
        {
            return _sliderDal.GetByID(id);
        }

        public List<Slider> TGetListAll()
        {
            return _sliderDal.GetListAll();
        }

        public void TUpdate(Slider Entity)
        {
            _sliderDal.Update(Entity);
        }
    }
}
