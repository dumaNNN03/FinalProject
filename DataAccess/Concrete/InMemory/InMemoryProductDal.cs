using DataAccess.Abstract;
using Entities.DTOs;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;


        public InMemoryProductDal()
        {
            // Bir veri tabanında bilgi geliyormuş gibi simüle ediyoruz.
            _products = new List<Product> {
                new Product{ProductId = 1,CategoryID=1,
                ProductName="Bardak",UnitPrice=15,UnitsInStock=15},

                new Product{ProductId = 2,CategoryID=1,
                ProductName="Kamera",UnitPrice=500,UnitsInStock=3},

                new Product{ProductId = 3,CategoryID=2,
                ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},

                new Product{ProductId = 4,CategoryID=2,
                ProductName="Klavye",UnitPrice=150,UnitsInStock=65},

                new Product{ProductId = 5,CategoryID=2,
                ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            throw new NotImplementedException();
        }
    }
}
