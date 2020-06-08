using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();

        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void SearchProducts(string key)
        {
            dgwProducts.DataSource = _productDal.GetAll().Where(p => p.Name.Contains(key)).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {

                Name = tbxName.Text,
                StockAmount = Convert.ToInt32(tbxStock.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)

            });
            LoadProducts();
            MessageBox.Show("Added");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxSearch.Text,
                StockAmount = Convert.ToInt32(tbxUptStock.Text),
                UnitPrice = Convert.ToDecimal(tbxUptUPrice.Text)

            }) ;
            LoadProducts();
            MessageBox.Show("Updated");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxSearch.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUptUPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxUptStock.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)

            });
            LoadProducts();
            MessageBox.Show("DELETED!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
    }
}
