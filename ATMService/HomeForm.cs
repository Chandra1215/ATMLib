using ATMLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMService
{
    public partial class HomeForm : Form
    {
        UserDataStore userDataStore = null;
        public HomeForm()
        {
            InitializeComponent();
            userDataStore = new UserDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        }
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {

            txtCardNumber.Text = LoginForm.CardNumber;

            var result = userDataStore.GetBalanceByCardNumber(txtCardNumber.Text);

            txtBalance.Text = result.ToString();

           



        }

        private void lblCardNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMiniStatement_Click(object sender, EventArgs e)
        {
           List<Transaction> transaction =new List<Transaction>();
            txtCardNumber.Text = LoginForm.CardNumber;

            transaction = userDataStore.GetTransaction(txtCardNumber.Text);

            gridTransaction.DataSource = transaction;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.ShowDialog();
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            WithDrawFrom withDrawFrom = new WithDrawFrom();
            withDrawFrom.ShowDialog();
        }
    }
}
