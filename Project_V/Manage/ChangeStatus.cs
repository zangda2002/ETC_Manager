using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project_V.Manage
{
    public partial class ChangeStatus : Form
    {
        public ChangeStatus()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        XmlElement taikhoan;
        string fileName = @"C:\Users\zangd\OneDrive\Máy tính\Project_V\Project_V\Login_file\Login.xml";
        private void ChangeStatus_Load(object sender, EventArgs e)
        {
            doc.Load(fileName);
            taikhoan = doc.DocumentElement;
            XmlNode node = taikhoan.SelectSingleNode("Taikhoan[@account='" + Properties.Settings.Default.Username + "']");
            txtacc.Text = node.SelectSingleNode("@account").Value;
            txtpass.Text = node.SelectSingleNode("password").InnerText;
            txtname.Text = node.SelectSingleNode("name").InnerText;
            lb1.Text = "Sửa thông tin cho người dùng: " + Properties.Settings.Default.Username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            taikhoan = doc.DocumentElement;
            XmlNode node = taikhoan.SelectSingleNode("Taikhoan[@account='" + Properties.Settings.Default.Username + "']");
            txtacc.Text = node.SelectSingleNode("@account").Value;
            txtpass.Text = node.SelectSingleNode("password").InnerText;
            txtname.Text = node.SelectSingleNode("name").InnerText;
            lb1.Text = "Sửa thông tin cho người dùng: " + Properties.Settings.Default.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);
            taikhoan = doc.DocumentElement;
            XmlNode node = taikhoan.SelectSingleNode("Taikhoan[@account='" + Properties.Settings.Default.Username + "']");
            if (node != null)
            {
                
                XmlNode ttk = doc.CreateElement("Taikhoan");
                
                XmlAttribute ma = doc.CreateAttribute("account");
                ma.InnerText = txtacc.Text;
                ttk.Attributes.Append(ma);
                          
                
                XmlElement mk = doc.CreateElement("password");
                mk.InnerText = txtpass.Text;
                ttk.AppendChild(mk);
                
                XmlElement ten = doc.CreateElement("name");
                ten.InnerText = txtname.Text;
                ttk.AppendChild(ten);


                taikhoan.ReplaceChild(ttk, node);
                doc.Save(fileName);
                if(Properties.Settings.Default.Username == Properties.Settings.Default.UsernameR)
                {
                    Properties.Settings.Default.UsernameR = "";
                    Properties.Settings.Default.PasswordR = "";
                }
                Properties.Settings.Default.Username = txtacc.Text;
                Properties.Settings.Default.Password = txtpass.Text;
                Properties.Settings.Default.Name = txtname.Text;
                
                MessageBox.Show("Change information Successfully!");
            }
        }

    }
}

