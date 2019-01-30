using NLayer.BLL.Concrete;
using NLayer.DAL.Concrete.EntityFramework;
using NLayer.DAL.Concrete.Nhibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayer.WebFormUI
{
    /*  BU KATMANDA SADECE BUSİNESS KATMANINA ULAŞILIR.
        KESİNLİKLE DATA ACCESS E GİDİLMEZ !!!!
        ÇÜNKÜ VERİTABANINDA SOYUTLANMALI YANİ BAĞIMSIZ OLMALIDIR.
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //IProductDal la çalıştığımız için, artık istersek EntityFramework'le istersek NHibernate'le çağırabiliriz.
            ProductManager productManager=new ProductManager(new EfProductDal());
            //ProductManager productManager = new ProductManager(new NhProductDal());
            dgwProduct.DataSource = productManager.GetAll();
        }
    }
}
