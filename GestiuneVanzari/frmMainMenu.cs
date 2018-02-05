using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestiuneVanzari.Entities;

namespace GestiuneVanzari
{
     
    public partial class frmMainMenu : Form
    {
        List<Product> _products;
        public frmMainMenu()
        {
            InitializeComponent();
            _products = new List<Product>();
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void tsClients_Click(object sender, EventArgs e)
        {
            frmClients frm = new frmClients();
            frm.ShowDialog();
        }

        private void tsProducts_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.ShowDialog();
        }

        private void tsTransactions_Click(object sender, EventArgs e)
        {
            frmTransactions frm = new frmTransactions();
            frm.ShowDialog();
        }

        private void tsLogout_Click(object sender, EventArgs e)
        {

        }
        private void tbShearchProd_Validated(object sender, EventArgs e)
        {
            //epName.Clear();
        }
        private void tbShearchProd_Validating(object sender, CancelEventArgs e)
        {
            //var name = tbShearchProd.Text.Trim(); // stergera spatiilor
            //if (string.IsNullOrWhiteSpace(name))
            //{
            //    e.Cancel = true; // util nu poate schimba textbox-ul
            //    epName.SetError(tbShearchProd, "Please enter a name!");
            //}
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvResult=null;
            foreach (var product in _products)
            {
                ListViewItem lvi = new ListViewItem(product.Name);
                //lvi.SubItems.Add(person.FirstName);
                //lvi.SubItems.Add(person.BirthDate.ToShortDateString());

                //lvPersons.Items.Add(lvi);

            }
        }




       
    }
}
