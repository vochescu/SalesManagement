using GestiuneVanzari.Entities;
using GestiuneVanzari.Exceptions;
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
    public partial class frmNewClient : Form
    {
        private Client client=new Client();
        public frmNewClient()
        {
            InitializeComponent();
        }
        public frmNewClient(Client cl)
        {
            InitializeComponent();
            client = cl;
        }

        private void frmNewClient_Load(object sender, EventArgs e)
        {
            tbFirstName.Text = client.FirstName;
            tbLastName.Text = client.LastName;
            tbPhone.Text = client.Phone;
            tbEmail.Text = client.Email;
            tbAdress.Text = client.Adress;
            cbCity.Text = client.City;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                client.FirstName = tbFirstName.Text;
                client.LastName = tbLastName.Text;
                client.Phone = tbPhone.Text;
                client.Email = tbEmail.Text;
                client.Adress = tbAdress.Text;
                client.City = cbCity.Text;
            }
            catch(InvalidNameException ex)
            {
                MessageBox.Show("The Name ' ' is invalid!", "Error", MessageBoxButtons.OK);
            }
            catch (InvalidPhoneException ex)
            {
                MessageBox.Show("The Phone " + ex.Phone + " is invalid!", "Error", MessageBoxButtons.OK);
            }
            catch (InvalidEmailException ex)
            {
                MessageBox.Show("The Email " + ex.Email + " is invalid!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
