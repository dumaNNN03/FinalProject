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
        List<Product> GetAll();

        Product Get(int Id);

        List<Product> GetAllByCategoryId(int id);

        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
