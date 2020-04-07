using System;
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
    public partial class MainWindowForm : Form
    {
        private int childFormNumber = 0;
        private bool loggedIn = false;
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void csomagToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kilépélsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            if (loggedIn) 
            {
                
            }
        }

        private void felhasználókToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void felhasználóListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form childForm = new userForm();
            //childForm.MdiParent = this;
            //childForm.Show();
            panel1.Controls.Clear();
            Form userForm = new userForm();
            userForm.FormBorderStyle = FormBorderStyle.None;
            userForm.AutoScroll = true;
            userForm.TopLevel = false;
            panel1.Controls.Add(userForm);
            userForm.Show();
            //MainWindowForm.hide();
        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolbar.Visible)
            {
                this.toolbarButton.Image = null;
                toolbar.Visible = false;
            }
            else 
            {
                this.toolbarButton.Image = global::transport_2.Properties.Resources.check;
                toolbar.Visible = true;
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusbar.Visible)
            {
                this.statusbarButton.Image = null;
                statusbar.Visible = false;
            }
            else
            {
                this.statusbarButton.Image = global::transport_2.Properties.Resources.check;
                statusbar.Visible = true;
            }
        }

        private void nevemenLévőCsomagokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form childForm = new userForm();
            //childForm.MdiParent = this;
            //childForm.Show();
            panel1.Controls.Clear();
            Form packageForm = new packageForm();
            packageForm.FormBorderStyle = FormBorderStyle.None;
            packageForm.AutoScroll = true;
            packageForm.TopLevel = false;
            panel1.Controls.Add(packageForm);
            packageForm.Show();
            //MainWindowForm.hide();
        }

        private void ügyféltőlFelvehetőCsomagokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form childForm = new userForm();
            //childForm.MdiParent = this;
            //childForm.Show();
            panel1.Controls.Clear();
            Form packageForm = new packageFromCustomerForm();
            packageForm.FormBorderStyle = FormBorderStyle.None;
            packageForm.AutoScroll = true;
            packageForm.TopLevel = false;
            panel1.Controls.Add(packageForm);
            packageForm.Show();
            //MainWindowForm.hide();
        }

        private void transferstatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form childForm = new userForm();
            //childForm.MdiParent = this;
            //childForm.Show();
            panel1.Controls.Clear();
            Form trasferStatusForm = new trasferStatusForm();
            trasferStatusForm.FormBorderStyle = FormBorderStyle.None;
            trasferStatusForm.AutoScroll = true;
            trasferStatusForm.TopLevel = false;
            panel1.Controls.Add(trasferStatusForm);
            trasferStatusForm.Show();
            //MainWindowForm.hide();
        }
    }
}
