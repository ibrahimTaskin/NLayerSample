using NLayer.Entities.Concrete;
using NLayer.Entities.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.DAL.Abstract;

namespace NLayer.DAL.Concrete.EntityFramework
{
    //veritabanı işlemleri bu katmandan yapılır. (select/update/add/delete vb.)
    public class EfProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //tek ürün geldiği için singleorDefault
                return context.Products.SingleOrDefault(p => p.ProductId == id); 
            }
        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {

        }

        public void Delete(Product product)
        {

        }
    }
}
