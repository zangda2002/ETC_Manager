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
    public partial class QLGVF : Form
    {

        string fileName = @"C:\Users\zangd\OneDrive\Máy tính\Project_V\qlgv\KiemTra (1)\KiemTra\KiemTra\gv.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_gv;



        public QLGVF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            show(dgv1);
        }



        void show(DataGridView dgv)
        {

            doc.Load(fileName);

            ql_gv = doc.DocumentElement;
            XmlNodeList ds = ql_gv.SelectNodes("Giaovien");

            int sd = 0;
            foreach (XmlNode node in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = node.SelectSingleNode("@Magv").Value;
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("Hoten").InnerText;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("Gioitinh").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("Namsinh").InnerText;
           //    dgv.Rows[sd].Cells[4].Value = node.SelectSingleNode("Diachi").InnerText;
                dgv.Rows[sd].Cells[5].Value = node.SelectSingleNode("Sdt").InnerText;
                dgv.Rows[sd].Cells[6].Value = node.SelectSingleNode("Monday").InnerText;
                sd++;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {


            doc.Load(fileName);

            ql_gv = doc.DocumentElement;

            XmlNode gv = doc.CreateElement("Giaovien");
            XmlAttribute magv = doc.CreateAttribute("Magv");

            magv.Value = txt_magv.Text;
            gv.Attributes.Append(magv);

            XmlElement hoten = doc.CreateElement("Hoten");
            hoten.InnerText = txt_ht.Text;

            gv.AppendChild(hoten);

            XmlElement gt = doc.CreateElement("Gioitinh");
            gt.InnerText = txt_gt.Text;

            gv.AppendChild(gt);

            XmlElement ns = doc.CreateElement("Namsinh");
            ns.InnerText = txtns.Text;

            gv.AppendChild(ns);

            XmlElement diachi = doc.CreateElement("Diachi");
            diachi.InnerText = txtdc.Text;

            gv.AppendChild(diachi);

            XmlElement sdt = doc.CreateElement("Sdt");
            sdt.InnerText = txt_sdt.Text;

            gv.AppendChild(sdt);
            XmlElement monday = doc.CreateElement("Monday");
            monday.InnerText = txtmon.Text;

            gv.AppendChild(monday);
            ql_gv.AppendChild(gv);
            doc.Save(fileName);
            dgv1.Rows.Clear();
            show(dgv1);

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowIndex = dgv1.CurrentCell.RowIndex;
            Form2 form2 = new Form2(dgv1.Rows[rowIndex].Cells[0].Value.ToString());
            form2.Text = dgv1.Rows[rowIndex].Cells[2].Value.ToString();
            form2.ShowDialog();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);

            ql_gv = doc.DocumentElement;
            XmlNodeList ds = ql_gv.SelectNodes("Giaovien");
            XmlNode gvcu =ql_gv.SelectSingleNode("Giaovien[@Magv ='" + txt_magv.Text + "']");

            XmlNode gv = doc.CreateElement("Giaovien");
            XmlAttribute magv = doc.CreateAttribute("Magv");

            magv.Value = txt_magv.Text;
            gv.Attributes.Append(magv);

            XmlElement hoten = doc.CreateElement("Hoten");
            hoten.InnerText = txt_ht.Text;

            gv.AppendChild(hoten);

            XmlElement gt = doc.CreateElement("Gioitinh");
            gt.InnerText = txt_gt.Text;

            gv.AppendChild(gt);

            XmlElement ns = doc.CreateElement("Namsinh");
            ns.InnerText = txtns.Text;

            gv.AppendChild(ns);

            XmlElement diachi = doc.CreateElement("Diachi");
            diachi.InnerText = txtdc.Text;

            gv.AppendChild(diachi);

            XmlElement sdt = doc.CreateElement("Sdt");
            sdt.InnerText = txt_sdt.Text;

            gv.AppendChild(sdt);

            XmlElement monday = doc.CreateElement("Monday");
            monday.InnerText = txtmon.Text;

            gv.AppendChild(monday);

            ql_gv.ReplaceChild(gv,gvcu);
            doc.Save(fileName);
            dgv1.Rows.Clear();
            show(dgv1);

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgv1.CurrentCell.RowIndex;
            txt_magv.Text = dgv1.Rows[rowIndex].Cells[0].Value.ToString();
            txt_ht.Text = dgv1.Rows[rowIndex].Cells[1].Value.ToString();
            txt_gt.Text = dgv1.Rows[rowIndex].Cells[2].Value.ToString();
            txtns.Text = dgv1.Rows[rowIndex].Cells[3].Value.ToString();
           //txtdc.Text = dgv1.Rows[rowIndex].Cells[4].Value.ToString();
            txt_sdt.Text = dgv1.Rows[rowIndex].Cells[5].Value.ToString();
            txtmon.Text = dgv1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);

            ql_gv = doc.DocumentElement;
            XmlNode gv = ql_gv.SelectSingleNode("Giaovien[@Magv ='" + txt_magv.Text + "']");
            if (gv != null)
            {
                  ql_gv.RemoveChild(gv);
             }      
            doc.Save(fileName);
                dgv1.Rows.Clear();
                show(dgv1);


            }


        private void btn_timkiem_Click_1(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            doc.Load(fileName);
            ql_gv = doc.DocumentElement;
            XmlNode node = ql_gv.SelectSingleNode("Giaovien[Magv ='" + txt_timkiem.Text + "']");

            if (node != null)
            {
                int sd = 0;
                dgv1.Rows.Add();
                dgv1.Rows[sd].Cells[0].Value = node.SelectSingleNode("@Magv").Value;
                dgv1.Rows[sd].Cells[1].Value = node.SelectSingleNode("Hoten").InnerText;
                dgv1.Rows[sd].Cells[2].Value = node.SelectSingleNode("Gioitinh").InnerText;
                dgv1.Rows[sd].Cells[3].Value = node.SelectSingleNode("Namsinh").InnerText;
                dgv1.Rows[sd].Cells[4].Value = node.SelectSingleNode("Diachi").InnerText;
                dgv1.Rows[sd].Cells[5].Value = node.SelectSingleNode("Sdt").InnerText;
                dgv1.Rows[sd].Cells[6].Value = node.SelectSingleNode("Monday").InnerText;
            }

            if (txt_timkiem.Text == "")
            {
                show(dgv1);
            }

        }
    }
    }
