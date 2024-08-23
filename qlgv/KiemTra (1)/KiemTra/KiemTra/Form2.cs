using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KiemTra
{
    public partial class Form2 : Form
    {

        string fileName = @"C:\Users\zangd\OneDrive\Máy tính\Project_V\qlgv\KiemTra (1)\KiemTra\KiemTra\gv.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_gv;
        private string magv;
        public Form2(string magv)
        {
            InitializeComponent();
            this.magv = magv;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            show(dgv2);
        }


        void show(DataGridView dgv)
        {

            doc.Load(fileName);

            ql_gv = doc.DocumentElement;
            XmlNode gv = ql_gv.SelectSingleNode("Giaovien[@Magv ='" + this.magv + "']");
            if (gv != null)
            {
                XmlNodeList Lop = gv.SelectNodes("Lop");
                int sd = 0;
                foreach (XmlNode node in Lop)
                {
                    dgv.Rows.Add();
                    dgv.Rows[sd].Cells[0].Value = node.SelectSingleNode("@Mal").Value;
                    dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("Tenlop").InnerText;
                    dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("Soluong").InnerText;
                     sd++;
                }
            }

        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (dgv2.CurrentCell != null && dgv2.CurrentCell.RowIndex >= 0)
            {
                int rowIndex = dgv2.CurrentCell.RowIndex;

                txt_mal.Text = dgv2.Rows[rowIndex].Cells[0].Value.ToString();
                txt_tenl.Text = dgv2.Rows[rowIndex].Cells[1].Value.ToString();
                txt_sl.Text = dgv2.Rows[rowIndex].Cells[2].Value.ToString();
               }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);

            ql_gv = doc.DocumentElement;
            XmlNode gv = ql_gv.SelectSingleNode("Giaovien[@Magv ='" + this.magv + "']");
            if (gv != null)
            {
                XmlNode Lop = doc.CreateElement("Lop");
                XmlAttribute malop = doc.CreateAttribute("Mal");

                malop.Value = txt_mal.Text;
                Lop.Attributes.Append(malop);
                XmlElement tenl = doc.CreateElement("Tenlop");
                tenl.InnerText = txt_tenl.Text;

                Lop.AppendChild(tenl);

                XmlElement sl = doc.CreateElement("Soluong");
                sl.InnerText = txt_sl.Text;

                Lop.AppendChild(sl);

                gv.AppendChild(Lop);
                doc.Save(fileName);
                dgv2.Rows.Clear();
                show(dgv2);



            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);

            ql_gv = doc.DocumentElement;
            XmlNode gv = ql_gv.SelectSingleNode("Giaovien[@Magv ='" + this.magv + "']");
            if (gv != null)
            {
                XmlNode Lop = gv.SelectSingleNode("Lop[@Mal ='" + txt_mal.Text + "']");
                if (Lop != null)
                {
                    gv.RemoveChild(Lop);
                }
                doc.Save(fileName);
                dgv2.Rows.Clear();
                show(dgv2);


            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);

            ql_gv = doc.DocumentElement;
            XmlNode gv = ql_gv.SelectSingleNode("Giaovien[@Magv ='" + this.magv + "']");
            if (gv != null)

            {
                XmlNode Lopcu = gv.SelectSingleNode("Lop[@Mal ='" + txt_mal.Text + "']");

                XmlNode Lop = doc.CreateElement("Lop");
                XmlAttribute malop = doc.CreateAttribute("Mal");

                malop.Value = txt_mal.Text;
                Lop.Attributes.Append(malop);
                XmlElement tenl = doc.CreateElement("Tenlop");
                tenl.InnerText = txt_tenl.Text;

                Lop.AppendChild(tenl);

                XmlElement sl = doc.CreateElement("Soluong");
                sl.InnerText = txt_sl.Text;

                Lop.AppendChild(sl);

                gv.ReplaceChild(Lop,Lopcu);
                doc.Save(fileName);
                dgv2.Rows.Clear();
                show(dgv2);



            }
        }
    }
}
