
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product();
            //Category();

        }

        private static void Category()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void Product()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //Console.WriteLine(productManager.Get(5).ProductName);
            //foreach (var product in productManager.GetAllByCategoryId(5))
            //{
            //    Console.WriteLine(product.CategoryID + " " + product.ProductName);
            //}

            //foreach (var product in productManager.GetByUnitPrice(10, 20))
            //{
            //    Console.WriteLine(product.ProductName + " " + product.UnitPrice);
            //}
            foreach (var item in productManager.GetProductDetail())
            {
                Console.WriteLine(item.CategoryName+" "+item.ProductName);
            }
        }
    }
}
