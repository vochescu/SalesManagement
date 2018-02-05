using GestiuneVanzari.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneVanzari
{
    public partial class frmEditProduct : Form
    {
        public Product product;

        public frmEditProduct(Product prd)
        {
            
            InitializeComponent();
            product = prd;
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            tbProductName.Text = product.Name;
            tbPrice.Text = product.Price.ToString();
            tbDescription.Text = product.Description;
            dtpExpDate.Value= product._expirationDate;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            product.Name = tbProductName.Text;
            product.Price=decimal.Parse(tbPrice.Text);
            product.Description = tbDescription.Text;
            product.ExpirationDate = dtpExpDate.Value;
        }

        private void tbProductName_Validating(object sender, CancelEventArgs e)
        {
            var productName = tbProductName.Text.Trim();
            if(string.IsNullOrWhiteSpace(productName))
            {
                e.Cancel = true;
                epProductName.SetError(tbProductName, "Enter a name!");
            }
        }

        private void tbProductName_Validated(object sender, EventArgs e)
        {
            epProductName.Clear();
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            var text = tbPrice.Text.Trim();
            if(string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true;
                epPrice.SetError(tbPrice, "Enter a price!");
            }
            else
            { 
                decimal i;
                if (!decimal.TryParse(text,out i))
                {
                    e.Cancel = true;
                    epPrice.SetError(tbPrice, "Enter a price!");
                }
                else
                {
                    var price = decimal.Parse(text); 
                    if(price <= 0)
                    {
                        e.Cancel = true;
                        epPrice.SetError(tbPrice, "Enter a pozitiv price!");
                    }
                }
            }
        }

        private void tbPrice_Validated(object sender, EventArgs e)
        {
            epPrice.Clear();
        }

        private void dtpExpDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt = dtpExpDate.Value;
            if(DateTime.Compare(dt,DateTime.Today) <= 0)
            {
                e.Cancel = true;
                epExpirationDate.SetError(dtpExpDate, "Enter a valid expiration date!");
            }
        }

        private void dtpExpDate_Validated(object sender, EventArgs e)
        {
            epExpirationDate.Clear();
        }
    }
}
