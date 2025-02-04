﻿using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntitiLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Concrete
{
    public class CategoryMenager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryMenager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public int TActiveCategoryCount()
        {
            return _categoryDal.ActiveCategoryCount();
        }

        public void TAdd(Category Entity)
        {
            _categoryDal.Add(Entity);
        }

        public int TCategoryCount()
        {
           return _categoryDal.CategoryCount();
        }

        public void TDelete(Category Entity)
        {
            _categoryDal.Delete(Entity);
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public int TPassiveCategoryCount()
        {
            return _categoryDal.PassiveCategoryCount();
        }

        public void TUpdate(Category Entity)
        {
            _categoryDal.Update(Entity);
        }
    }
}
