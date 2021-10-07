using Core.Utilities.Results;
using Entities.DTOs;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IDataResult<Product> Get(int Id);

        IDataResult<List<Product>> GetAllByCategoryId(int id);

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        public IDataResult<List<ProductDetailDto>> GetProductDetail();

        IResult Add(Product product);

        IDataResult<Product> GetById(int ID);

        IResult Update(Product product);
    }
}
