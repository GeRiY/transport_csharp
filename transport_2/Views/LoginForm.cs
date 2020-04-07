using System;
using transport_2.Models;
using transport_2.Repositories;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transport_2.Views
{
    public partial class LoginForm : Form
    {

        private userRepository userRepository;

        public LoginForm()
        {
            userRepository = new userRepository();
            InitializeComponent();
     
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = this.userName.Text;
            string password = this.password.Text;
           fos_user user = userRepository.getUserByUserName(userName);

            if (CryptSharp.Crypter.CheckPassword(password, user.password)) {

                //MainWindowForm.onUserLoggedIn(this.Parent, e);
                Control[] mwf = base.Controls.Find("MainWindowForm", false);

                //mwf[0].Invoke
            }
        }
    }
}
