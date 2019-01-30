using NLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.DAL.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
