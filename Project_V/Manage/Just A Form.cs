using QLHS;
using bainhom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_V.Manage
{
    public partial class Just_A_Form : Form
    {
        public Just_A_Form()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.Settings.Default.Name = "";
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Password = "";
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void Just_A_Form_Load(object sender, EventArgs e)
        {
            lbdefault.Text = "Chào mừng " + Properties.Settings.Default.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLHS.QLHSF f1 = new QLHS.QLHSF();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeStatus cs = new ChangeStatus();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           QLTTB ql = new QLTTB();
            ql.Show();
        }
    }
}
