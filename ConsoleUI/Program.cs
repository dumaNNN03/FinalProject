
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
            Product();
            //Category();

        }

        private static void Category()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll().Data)
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void Product()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
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
            var result = productManager.GetProductDetail();
            if(result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.CategoryName + " " + product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);

            }
            
            
        }
    }
}
