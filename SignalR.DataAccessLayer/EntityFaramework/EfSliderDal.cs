﻿using SignalR.DataAccessLayer.Abstract;
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
    public class EfSliderDal:GenericRepository<Slider>,ISliderDal
    {
        public EfSliderDal(SignalRContext context):base(context)
        {
            
        }
    }
}
