﻿using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Conctrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiLayer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        public List<Product> GetLast9Products()
        {
            SignalRContext context = new SignalRContext();
            var values = context.Products.OrderByDescending(x => x.ProductID).Take(9).ToList();
            return values;
        }

        public List<Product> GetProductsWithCategories()
        {
            SignalRContext context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public decimal ProductAverageByHamburger()
        {
            SignalRContext context = new SignalRContext();

            return context.Products.Where(x => x.Category.CategoryName == "Hamburger").Select(y => y.Price).Average();
        }

        public int ProductCount()
        {
            SignalRContext context = new SignalRContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            SignalRContext context = new SignalRContext();
            return context.Products.Where(x => x.Category.CategoryName == "İçecek").Select(y => y.CategoryID).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            SignalRContext context = new SignalRContext();
            return context.Products.Where(x => x.Category.CategoryName == "Hamburger").Select(y => y.CategoryID).Count();
        }

        public string ProductNameByMaxPrice()
        {
            SignalRContext context = new SignalRContext();
            return context.Products.OrderByDescending(x => x.Price).Select(y => y.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            SignalRContext context = new SignalRContext();
            return context.Products.OrderBy(x => x.Price).Select(y => y.ProductName).FirstOrDefault();
        }

		public decimal ProductPriceBySteakBurger()
		{
			SignalRContext context = new SignalRContext();
            return context.Products.Where(x => x.ProductName == "Steak Burger").Select(y => y.Price).FirstOrDefault();
		}

        public decimal TotalPriceByDrinkCategory()
        {
            SignalRContext context = new SignalRContext();

            return context.Products.Where(x => x.Category.CategoryName == "İçecek").Sum(y => y.Price);
        }

        public decimal TotalPriceBySaladCategory()
        {
            SignalRContext context = new SignalRContext();

            return context.Products.Where(x => x.Category.CategoryName == "Salata").Sum(y => y.Price);
        }

        decimal IProductDal.ProductAveragePrice()
        {
            SignalRContext context = new SignalRContext();
            return context.Products.Average(x => x.Price);


        }


    }
}
