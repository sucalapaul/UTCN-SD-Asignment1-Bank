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
    public partial class NewAccountForm : Form
    {
        private POCO.Account account;

        public NewAccountForm()
        {
            InitializeComponent();
        }

        public NewAccountForm(POCO.Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Save
            account.Amount = 0;
            account.Number = number.Text;
            account.Type = Int32.Parse(type.Text);
            account.Currency = Int32.Parse(currency.Text);
            account.CreationDate = DateTime.Today.ToShortDateString();

            this.Close();
        }
    }
}
