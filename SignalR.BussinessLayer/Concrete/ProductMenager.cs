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
    public class ProductMenager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductMenager(IProductDal productDal)
        {
            _productDal = productDal;
        }

       

        public void TAdd(Product Entity)
        {
            _productDal.Add(Entity);
        }

        public void TDelete(Product Entity)
        {
            _productDal.Delete(Entity);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetLast9Products()
        {
            return _productDal.GetLast9Products();
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public List<Product> TGetProductsWithCategories()
        {
           return _productDal.GetProductsWithCategories();
        }

        public decimal TProductAverageByHamburger()
        {
            return _productDal.ProductAverageByHamburger();
        }

        public decimal TProductAveragePrice()
        {
            return _productDal.ProductAveragePrice();
        }

        public int TProductCount()
        {
            return _productDal.ProductCount();
        }

        public int TProductCountByCategoryNameDrink()
        {
            return _productDal.ProductCountByCategoryNameDrink();
        }

        public int TProductCountByCategoryNameHamburger()
        {
            return _productDal.ProductCountByCategoryNameHamburger();
        }

        public string TProductNameByMaxPrice()
        {
            return _productDal.ProductNameByMaxPrice();
        }

        public string TProductNameByMinPrice()
        {
            return _productDal.ProductNameByMinPrice();
        }

		public decimal TProductPriceBySteakBurger()
		{
            return _productDal.ProductPriceBySteakBurger();
		}

        public decimal TTotalPriceByDrinkCategory()
        {
            return _productDal.TotalPriceByDrinkCategory();
        }

        public decimal TTotalPriceBySaladCategory()
        {
            return _productDal.TotalPriceBySaladCategory();
        }

        public void TUpdate(Product Entity)
        {
            _productDal.Update(Entity);
        }
    }
}
