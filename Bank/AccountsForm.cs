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
    public partial class AccountsForm : Form
    {
        private AccountBiz business;
        private int clientId;
        public AccountsForm()
        {
            InitializeComponent();
            business = new AccountBiz();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            POCO.Client client = business.Search(searchCNP.Text);
            refreshFields(client);
        }

        private void reload()
        {
            POCO.Client client = business.Get(clientId);
            refreshFields(client);
        }

        private void refreshFields(POCO.Client client)
        {
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
                this.cnp.Text = client.CNP;
                this.icn.Text = client.ICN;
                this.address.Text = client.Address;

                foreach (var a in client.Accounts)
                {
                    accountList.Rows.Add(new object[] { a.ID, a.Number, a.Type, a.Currency, a.Amount, a.CreationDate });
                }
                searchCNP.Clear();
            }

        }

        private void clearFields()
        {
            firstName.Text = "(empty)";
            lastName.Text = "(empty)";
            cnp.Text = "(empty)";
            icn.Text = "(empty)";
            address.Text = "(empty)";
            clientId = 0;
            searchCNP.Clear();
            accountList.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new account
            POCO.Account account = new POCO.Account();
            account.ClientID = clientId;

            Form accountForm = new NewAccountForm(account);
            accountForm.ShowDialog();

            business.Save(account);
            reload();
        }

    }
}
