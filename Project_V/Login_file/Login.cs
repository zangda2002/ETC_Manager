using Project_V.Manage;
using QLHS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Project_V
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        XmlElement taikhoan;
        string fileName = @"C:\Users\zangd\OneDrive\Máy tính\Project_V\Project_V\Login_file\Login.xml";
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtacc.Text == ""|| txtpass.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                doc.Load(fileName);
                taikhoan = doc.DocumentElement;
                XmlNodeList tknode = taikhoan.SelectNodes("Taikhoan");
                XmlNode node = taikhoan.SelectSingleNode("Taikhoan[@account='" + txtacc.Text + "']");

                if (node != null)
                {
                    String x = node.SelectSingleNode("@account").Value;
                    String y = node.SelectSingleNode("password").InnerText;
                    String z = node.SelectSingleNode("name").InnerText;
                    String r = node.SelectSingleNode("role").InnerText;
                    if (y == txtpass.Text)
                    {
                        Properties.Settings.Default.Username = x;
                        Properties.Settings.Default.Password = y;
                        Properties.Settings.Default.Name = z;
                        Properties.Settings.Default.Name = r;
                        MessageBox.Show("Login Successfull");
                        if (r == "admin")
                        {
                            Just_A_Form_Admintrastor_ jaf = new Just_A_Form_Admintrastor_();
                            jaf.Show();
                            this.Hide();
                        }
                        else
                        {
                            Just_A_Form jaf = new Just_A_Form();
                            jaf.Show();
                            this.Hide();
                        }

                        if (rememberme.Checked == true)
                        {
                            Properties.Settings.Default.UsernameR = txtacc.Text;
                            Properties.Settings.Default.PasswordR = txtpass.Text;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.UsernameR = "";
                            Properties.Settings.Default.PasswordR = "";
                            Properties.Settings.Default.Save();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!");
                    }

                }
                else
                {
                    MessageBox.Show("This Account Not Exist!");


                }
            }
           
            //foreach (XmlNode item in tknode)
            //{
            //    string ac = item.SelectSingleNode("@account").Value;
            //    string pass = item.SelectSingleNode("password").InnerText;
            //    string name = item.SelectSingleNode("name").InnerText;
            //    if (ac == txtacc.Text && pass == txtpass.Text)
            //    {
            //        Properties.Settings.Default.Username = ac;
            //        Properties.Settings.Default.Password = pass;
            //        Properties.Settings.Default.Name = name;
            //        MessageBox.Show("Login Successfull");
            //        Just_A_Form jaf = new Just_A_Form();
            //        jaf.Show();
            //        this.Hide();

            //        if (rememberme.Checked == true)
            //        {
            //            Properties.Settings.Default.UsernameR = txtacc.Text;
            //            Properties.Settings.Default.PasswordR = txtpass.Text;
            //            Properties.Settings.Default.Save();
            //        }
            //        else
            //        {
            //            Properties.Settings.Default.UsernameR = "";
            //            Properties.Settings.Default.PasswordR = "";
            //            Properties.Settings.Default.Save();
            //        }

            //        break;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wrong Password or Account");


            //    }


            //}

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UsernameR != string.Empty)
            {
                txtacc.Text = Properties.Settings.Default.UsernameR;
                txtpass.Text = Properties.Settings.Default.PasswordR;
            }
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
            button2.Hide();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
            button3.Hide();
            button2.Show();
        }
    }
}
