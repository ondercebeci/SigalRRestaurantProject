﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
	public  interface IGenericDal<T> where T : class
	{
		void Add(T Entity);
		void Delete(T Entity);
		void Update(T Entity);
		T GetByID(int id);
		List<T> GetListAll();

	}
}
