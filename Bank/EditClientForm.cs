using Bank.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class EditClientForm : Form
    {
        private ClientBiz clientBiz;
        private int clientId;
        public EditClientForm()
        {
            InitializeComponent();
            clientBiz = new ClientBiz();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            POCO.Client client = clientBiz.Search(searchCNP.Text);
            clearFields();
            if (client == null)
            {
                MessageBox.Show("Not Found!");
            }
            else
            {
                this.firstName.Text = client.FirstName;
                this.clientId = client.ID;
                this.lastName.Text = client.LastName;
                this.CNP.Text = client.CNP;
                this.ICN.Text = client.ICN;
                this.address.Text = client.Address;
            }
            searchCNP.Clear();
        }

        private void EditClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            clientId = clientBiz.Save(clientId, firstName.Text, lastName.Text, address.Text, CNP.Text, ICN.Text);
            if (clientId > 0)
            {
                MessageBox.Show("Saved suuccessfullyyy");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (clientBiz.Delete(clientId))
            {
                MessageBox.Show("Deleted succesfully!");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
            clearFields();
        }

        private void clearFields()
        {
            firstName.Clear();
            lastName.Clear(); 
            CNP.Clear();
            ICN.Clear();
            address.Clear();
            clientId = 0;
            searchCNP.Clear();
        }
    }
}
