﻿using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Conctrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFaramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public EfProductDal(SignalRContext context) : base(context)
		{
		}
	}
}