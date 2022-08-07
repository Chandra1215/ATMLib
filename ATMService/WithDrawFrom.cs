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
    public partial class WithDrawFrom : Form
    {
        UserDataStore userDataStore = null;
        public WithDrawFrom()
        {
            InitializeComponent();
            userDataStore = new UserDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        }

        private void btnWithDrawAmount_Click(object sender, EventArgs e)
        {
            txtCardNumber.Text = LoginForm.CardNumber;
            User user = new User();
            user.Balance = Convert.ToDecimal(txtWithDraw.Text);
            userDataStore.WithDrawAmount(txtCardNumber.Text, Convert.ToDecimal(txtWithDraw.Text));
            MessageBox.Show("Successfully WithDrawed");
        }
    }
}
