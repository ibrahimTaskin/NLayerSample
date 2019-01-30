using NLayer.DAL.Abstract;
using NLayer.DAL.Concrete;
using NLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.BLL.Concrete
{
    /*işlemlerimizi iş katmanında yaparız.
    Veritabanında gelen listeler/veriler aşağıdaki şartlara uyuyor mu?
    Kuralları bu katmanda belirleriz.*/
    public class ProductManager
    {
        private IProductDal _productDal;

        //dependency injection ile new yapmadan enjekte ediyoruz.
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            //İş kuralları ile ilgili kodlar buraya yazılır.
            return _productDal.GetAll();
        }
    }
}
