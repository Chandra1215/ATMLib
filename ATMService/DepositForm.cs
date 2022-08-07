using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMLib;
using System.Configuration;

namespace ATMService
{
    public partial class DepositForm : Form
    {
        UserDataStore userDataStore = null;
        public DepositForm()
        {
            InitializeComponent();
            userDataStore = new UserDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnDepositAmount_Click(object sender, EventArgs e)
        {
            txtCardNumber.Text = LoginForm.CardNumber;
            User user = new User();
            user.Balance = Convert.ToDecimal(txtAmount.Text);
            userDataStore.AddAmount(txtCardNumber.Text,Convert.ToDecimal(txtAmount.Text));
            MessageBox.Show("Successfully deposited");

        }
    }
}
