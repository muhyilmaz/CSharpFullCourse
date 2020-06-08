using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.ProductDemo
{
    public partial class frmMain : Form
    {
        ProductDal _productDal = new ProductDal();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStock.Text)
            });

            MessageBox.Show("Product Added");
            LoadProducts();
        }



        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUptName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUptUPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxUptStock.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxUptName.Text,
                UnitPrice = Convert.ToDecimal(tbxUptUPrice.Text),
                StockAmount = Convert.ToInt32(tbxUptStock.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("{0}. Product is  Deleted!!",id.ToString());
        }
    }
}
