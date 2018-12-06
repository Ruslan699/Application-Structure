using Shop.Business.Abstract;
using Shop.Business.Concrete;
using ShopDataAccess.Concrete;
using ShopDataAccess.Concrete.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _productService = new ProductManager(new EFProductDal());
        }

           private IProductService _productService;

        private void Form1_Load(object sender, EventArgs e)
        {
          

            dgwProduct.DataSource = _productService.GetAll();
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
