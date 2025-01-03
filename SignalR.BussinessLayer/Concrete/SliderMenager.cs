﻿using SignalR.BussinessLayer.Abstract;
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
            throw new NotImplementedException();
        }

        public void TDelete(Slider Entity)
        {
            throw new NotImplementedException();
        }

        public Slider TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Slider> TGetListAll()
        {
            return _sliderDal.GetListAll();
        }

        public void TUpdate(Slider Entity)
        {
            throw new NotImplementedException();
        }
    }
}
