using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetail()
        {
            using (NorthwindContext context = new())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryID equals c.CategoryId
                             select new ProductDetailDto { CategoryName = c.CategoryName, ProductID = p.ProductId, ProductName = p.ProductName, UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }
        }
    }
}
