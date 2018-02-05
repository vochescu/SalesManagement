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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using GestiuneVanzari.Exceptions;

namespace GestiuneVanzari
{
    public partial class frmProducts : Form
    {
        List<Product> products;
        public frmProducts()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var name = tbProductName.Text;
                decimal price = decimal.Parse(tbPrice.Text);
                DateTime expirationDate = dtpExpDate.Value;
                var description = tbDescription.Text;
                var product = new Product( name, description, price, expirationDate);
                products.Add(product);
                DisplayProducts();
                // reset
                tbProductName.Text = "";
                tbDescription.Text = "";
                tbPrice.Text = "";
                dtpExpDate.Value = DateTime.Today;
             }
            catch (InvalidExpirationDateException ex)
            {
                MessageBox.Show("The Expiration Date " + ex.ExpirationDate + " is invalid!","Error",MessageBoxButtons.OK);
                Product.idGenerator--;
            }
            catch (InvalidPriceException ex)
            {
                MessageBox.Show("The Price " + ex.Price + " is invalid!", "Error", MessageBoxButtons.OK);
                Product.idGenerator--;
            }
            catch (InvalidNameException ex)
            {
                MessageBox.Show("The Name ' ' " + ex.Name + " is invalid!", "Error", MessageBoxButtons.OK);
                Product.idGenerator--;
            }
        }
        void DisplayProducts()
        {
            lvProducts.Items.Clear();
            foreach (var product in products)
            {
                ListViewItem lvi = new ListViewItem(product.ProductId);
                lvi.SubItems.Add(product.Name);
                lvi.SubItems.Add(product.Description);
                lvi.SubItems.Add(product.Price.ToString());
                lvi.SubItems.Add(product.ExpirationDate.ToShortDateString());
                lvi.Tag = product;
                lvProducts.Items.Add(lvi);
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 1)
            {
                // ListViewItem lvi = lvProducts.SelectedItems[0];
                Product prd = (Product)lvProducts.SelectedItems[0].Tag;

                frmEditProduct editFrm = new frmEditProduct(prd);

                if (editFrm.ShowDialog() == DialogResult.OK)
                {
                    DisplayProducts();
                }
            }
            else
            {
                MessageBox.Show("Select a product!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    var lvi = lvProducts.SelectedItems[0];
                    Product prd = (Product)lvi.Tag;
                    products.Remove(prd);

                    DisplayProducts();
                }
            }
        }

        private void tbProductName_Validating(object sender, CancelEventArgs e)
        {

            //var productName = tbProductName.Text.Trim();
            //if (string.IsNullOrWhiteSpace(productName))
            //{
            //    e.Cancel = true;
            //    epProductName.SetError(tbProductName, "Enter a name!");
            //}
        }

        private void tbProductName_Validated(object sender, EventArgs e)
        {
            epProductName.Clear();
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            var text = tbPrice.Text.Trim();
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true;
                epPrice.SetError(tbPrice, "Enter a price!");
            }
            else
            {
                decimal i;
                if (!decimal.TryParse(text, out i))
                {
                    e.Cancel = true;
                    epPrice.SetError(tbPrice, "Enter a price!");
                }
                else
                {
                    var price = decimal.Parse(text);
                    if (price <= 0)
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
            //DateTime dt = dtpExpDate.Value;
            //if (DateTime.Compare(dt, DateTime.Today) <= 0)
            //{
            //    e.Cancel = true;
            //    epExpirationDate.SetError(dtpExpDate, "Enter a valid expiration date!");
            //}
        }

        private void dtpExpDate_Validated(object sender, EventArgs e)
        {
            epExpirationDate.Clear();
        }

        private void tsBinaryImport_Click(object sender, EventArgs e)
        {
            BinaryFormatter frm = new BinaryFormatter();
            using (FileStream s = File.OpenRead("Serialized.bin"))
            {
                products = (List<Product>)frm.Deserialize(s);
                DisplayProducts();
            }
        }

        private void tsBinaryExport_Click(object sender, EventArgs e)
        {
            BinaryFormatter frm = new BinaryFormatter();
            using (FileStream s = File.Create("Serialized.bin"))
            {
                frm.Serialize(s, products);
            }
        }

        private void tsCsvExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text File | *.txt";
			saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter s = new StreamWriter(saveFileDialog.FileName))
                {
                    s.WriteLine("Id;Name;Description;Price;ExpirationDate");

                    foreach (var product in products)
                    {
                        s.WriteLine("{0};{1};{2};{3};{4}"
                            , product.ProductId
                            , product.Name
                            , product.Description
                            , product.Price.ToString()
                            , product.ExpirationDate.ToShortDateString());
                    }
                }
            }
        }

        private void tsXmlExport_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            using (StreamWriter s = new StreamWriter("Serialized.xml"))
            {
                xml.Serialize(s, products);
            }
        }

        private void tsXmlImport_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            using (StreamReader s = new StreamReader("Serialized.xml"))
            {
                products = (List<Product>)xml.Deserialize(s);
                DisplayProducts();
            }

        }

        private void tsCsvImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT File|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String filename = ofd.FileName;
                using (StreamReader sr = new StreamReader(filename))
                {
                    var line = sr.ReadLine(); // citesc antetul
                    if (line != null)
                    {
                        line = sr.ReadLine();
                    }
                    while (line != null)
                    {
                        Product product = new Product();
                        String[] values = line.Split(';');
                        product.ProductId = values[0];
                        product.Name = values[1];
                        product.Description = values[2];
                        product.Price = decimal.Parse(values[3]);
                        product.ExpirationDate=Convert.ToDateTime(values[4]);
                        products.Add(product);
                        DisplayProducts();
                        line = sr.ReadLine();
                    }
                }
            }

        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter frm = new BinaryFormatter();
            using (FileStream s = File.Create("Serialized.bin"))
            {
                frm.Serialize(s, products);
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter frm = new BinaryFormatter();
                using (FileStream s = File.OpenRead("Serialized.bin"))
                {
                    products = (List<Product>)frm.Deserialize(s);
                    DisplayProducts();
                }
                Product.idGenerator = int.Parse(products.Last<Product>().ProductId);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine(ex);
            }

        }

       
    }
}
