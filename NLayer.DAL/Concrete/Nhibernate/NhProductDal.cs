using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.DAL.Abstract;
using NLayer.Entities.Concrete;

namespace NLayer.DAL.Concrete.Nhibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products=new List<Product>
            {
                new Product
                {
                    ProductId = 5,
                    ProductName = "Laptop",
                    UnitsInStock = 5,
                    UnitPrice = 50,
                    QuantityPerUnit = "seven time"

                }
            };
            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
