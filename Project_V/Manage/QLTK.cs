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
    public partial class QLTK : Form
    {
        public QLTK()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        XmlElement tk;
        string file = @"C:\Users\zangd\OneDrive\Máy tính\Project_V\Project_V\Login_file\Login.xml";

        public void Hienthi(DataGridView dgv)
        {
            doc.Load(file);
            tk = doc.DocumentElement;
            XmlNodeList ds = tk.SelectNodes("Taikhoan");
            int sd = 0;
            foreach (XmlNode node in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = node.SelectSingleNode("@account").Value;
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("password").InnerText;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("name").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("role").InnerText;                
                sd++;
            }
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            Hienthi(dgv);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtacc.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtpass.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtacc.Text == "" || txtname.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                doc.Load(file);
                tk = doc.DocumentElement;
                XmlNode nd = tk.SelectSingleNode("Taikhoan[@account='" + txtacc.Text + "']");
                if (nd != null)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
                else
                {
                    XmlNode ttk = doc.CreateElement("Taikhoan");

                    XmlAttribute ac = doc.CreateAttribute("account");
                    ac.InnerText = txtacc.Text;
                    ttk.Attributes.Append(ac);
                    XmlElement pa = doc.CreateElement("password");
                    pa.InnerText = txtpass.Text;
                    ttk.AppendChild(pa);
                    XmlElement na = doc.CreateElement("name");
                    na.InnerText = txtname.Text;
                    ttk.AppendChild(na);
                    XmlElement r = doc.CreateElement("role");
                    r.InnerText = "staff";
                    ttk.AppendChild(r);

                    tk.AppendChild(ttk);
                    doc.Save(file);
                    Hienthi(dgv);
                    MessageBox.Show("Additional Successful!");
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doc.Load(file);
            tk = doc.DocumentElement;
            XmlNode find = tk.SelectSingleNode("SV[@account='" + txtacc.Text + "']");
            if (find != null)
            {
                tk.RemoveChild(find);
                doc.Save(file);
            }
            dgv.Rows.Clear();
            Hienthi(dgv);
        }
    }
}
