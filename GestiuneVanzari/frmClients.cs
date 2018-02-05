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
    public partial class frmClients : Form
    {
        List<Client> clients;
        public frmClients()
        {
            InitializeComponent();
            clients = new List<Client>();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            frmNewClient frm = new frmNewClient();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try 
            {
            
            }
            catch(InvalidNameException ex)
            {
                MessageBox.Show("The Name ' ' " + ex.Name + " is invalid!", "Error", MessageBoxButtons.OK);
            }
        }
        void DisplayClients()
        {
            lvClients.Items.Clear();
            foreach (var client in clients)
            {
                ListViewItem lvi = new ListViewItem(client.ClientId);
                lvi.SubItems.Add(client.FirstName);
                lvi.SubItems.Add(client.LastName);
                lvi.SubItems.Add(client.Phone);
                lvi.SubItems.Add(client.Email);
                lvi.SubItems.Add(client.Adress);
                lvi.SubItems.Add(client.City);
                lvi.Tag = client;
                lvClients.Items.Add(lvi);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvClients.SelectedItems.Count == 1)
            {
                Client client = (Client)lvClients.SelectedItems[0].Tag;
                frmNewClient editFrm = new frmNewClient(client);

                if (editFrm.ShowDialog() == DialogResult.OK)
                {
                    DisplayClients();
                }
            }
            else
            {
                MessageBox.Show("Select a client!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvClients.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    var lvi = lvClients.SelectedItems[0];
                    Client client = (Client)lvi.Tag;
                    clients.Remove(client);

                    DisplayClients();
                }
            }
        }
    }
}
