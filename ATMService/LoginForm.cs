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
    public partial class LoginForm : Form
    {
        UserDataStore userDataStore = null;
        public LoginForm()
        {
            InitializeComponent();
            userDataStore = new UserDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        public static string CardNumber;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.CardNumber = txtCardNumber.Text;
            user.PinNumber = txtPinNumber.Text;

            var result = userDataStore.ValidateUser(user);




            if (result == true)
            {
                CardNumber = user.CardNumber;
                HomeForm homeForm = new HomeForm();
                homeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Details");
            }


        }
    }
}
