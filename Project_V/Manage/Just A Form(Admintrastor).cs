using bainhom;
using QLHS;
using KiemTra;
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
    public partial class Just_A_Form_Admintrastor_ : Form
    {
        public Just_A_Form_Admintrastor_()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLHSF ql = new QLHSF();
            ql.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeStatus cs =  new ChangeStatus();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLTTB qLTTB = new QLTTB();
            qLTTB.Show();
        }

        private void Just_A_Form_Admintrastor__Load(object sender, EventArgs e)
        {
            lbdefault.Text = "Chào mừng " + Properties.Settings.Default.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLGVF qv = new QLGVF();
            qv.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QLTK qt = new QLTK();
            qt.Show();
        }
    }
}
