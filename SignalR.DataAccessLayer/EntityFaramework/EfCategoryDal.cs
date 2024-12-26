using SignalR.DataAccessLayer.Abstract;
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
	public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		public EfCategoryDal(SignalRContext context) : base(context)
		{
		}

        public int ActiveCategoryCount()
        {
            SignalRContext context = new SignalRContext();
            return context.Categories.Count(x => x.Status == true);
        }

        public int CategoryCount()
        {
           
                SignalRContext context = new SignalRContext();
                return context.Categories.Count();
                
            
        }

        public int PassiveCategoryCount()
        {
            SignalRContext context = new SignalRContext();
            return context.Categories.Count(x => x.Status == false);
        }
    }
}
