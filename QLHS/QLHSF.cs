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
namespace QLHS
{
    public partial class QLHSF : Form
    {
        public QLHSF()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        XmlElement QLHS;
        string filename = @"C:\Users\zangd\OneDrive\Máy tính\Project_V\QLHS\XML\QLHS.xml";
        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthi(dataGridView1);
            LoadComboBoxData();
        }
        public void Hienthi(DataGridView dataGridView1)
        {
            doc.Load(filename);
            QLHS = doc.DocumentElement;
            XmlNodeList ds = QLHS.SelectNodes("SV");
            int sd = 0;
            foreach (XmlNode node in ds)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sd].Cells[0].Value = node.SelectSingleNode("@MaSV").Value;
                dataGridView1.Rows[sd].Cells[1].Value = node.SelectSingleNode("TenSV").InnerText;
                dataGridView1.Rows[sd].Cells[2].Value = node.SelectSingleNode("Gioitinh").InnerText;
                dataGridView1.Rows[sd].Cells[3].Value = node.SelectSingleNode("Diachi").InnerText;
                dataGridView1.Rows[sd].Cells[4].Value = node.SelectSingleNode("Lop").InnerText;
                dataGridView1.Rows[sd].Cells[5].Value = node.SelectSingleNode("NgayDK").InnerText;
                sd++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGioitinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLop.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            txtNgay.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            QLHS = doc.DocumentElement;
            //
            XmlNode ppl = doc.CreateElement("SV");
            //
            XmlAttribute ma = doc.CreateAttribute("MaSV");
            ma.InnerText = txtMa.Text;
            ppl.Attributes.Append(ma);
            //
            XmlElement ten = doc.CreateElement("TenSV");
            ten.InnerText = txtTen.Text;
            ppl.AppendChild(ten);
            //
            XmlElement diachi = doc.CreateElement("Diachi");
            diachi.InnerText = txtDiachi.Text;
            ppl.AppendChild(diachi);
            //
            XmlElement gt = doc.CreateElement("Gioitinh");
            gt.InnerText = txtGioitinh.Text;
            ppl.AppendChild(gt);
            //
            XmlElement ngay = doc.CreateElement("NgayDK");
            ngay.InnerText = txtNgay.Text;
            ppl.AppendChild(ngay);
            //
            XmlElement lop = doc.CreateElement("Lop");
            lop.InnerText = txtLop.Text;
            ppl.AppendChild(lop);
            //
            comboBox1.Items.Add(txtLop.Text);
            //
            QLHS.AppendChild(ppl);
            doc.Save(filename);
            Hienthi(dataGridView1);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            QLHS = doc.DocumentElement;
            XmlNode find = QLHS.SelectSingleNode("SV[@MaSV='" + txtMa.Text + "']");
            if (find != null)
            {
                //
                XmlNode ppl = doc.CreateElement("SV");
                //
                XmlAttribute ma = doc.CreateAttribute("MaSV");
                ma.InnerText = txtMa.Text;
                ppl.Attributes.Append(ma);
                //
                XmlElement ten = doc.CreateElement("TenSV");
                ten.InnerText = txtTen.Text;
                ppl.AppendChild(ten);
                //
                XmlElement diachi = doc.CreateElement("Diachi");
                diachi.InnerText = txtDiachi.Text;
                ppl.AppendChild(diachi);
                //
                XmlElement gt = doc.CreateElement("Gioitinh");
                gt.InnerText = txtGioitinh.Text;
                ppl.AppendChild(gt);
                //
                XmlElement ngay = doc.CreateElement("NgayDK");
                ngay.InnerText = txtNgay.Text;
                ppl.AppendChild(ngay);
                //
                XmlElement lop = doc.CreateElement("Lop");
                lop.InnerText = txtLop.Text;
                ppl.AppendChild(lop);
                QLHS.ReplaceChild(ppl, find);
                doc.Save(filename);
                Hienthi(dataGridView1);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            QLHS = doc.DocumentElement;
            XmlNode find = QLHS.SelectSingleNode("SV[@MaSV='" + txtMa.Text + "']");
            if (find != null)
            {
                QLHS.RemoveChild(find);
                doc.Save(filename);
            }
            dataGridView1.Rows.Clear();
            Hienthi(dataGridView1);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            QLHS = doc.DocumentElement;
            XmlNode find = QLHS.SelectSingleNode("SV[@MaSV='" + txtMa.Text + "']");
            if (find != null) 
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows[0].Cells[0].Value = find.SelectSingleNode("@MaSV").Value;
                dataGridView1.Rows[0].Cells[1].Value = find.SelectSingleNode("TenSV").InnerText;
                dataGridView1.Rows[0].Cells[2].Value = find.SelectSingleNode("Gioitinh").InnerText;
                dataGridView1.Rows[0].Cells[3].Value = find.SelectSingleNode("Diachi").InnerText;
                dataGridView1.Rows[0].Cells[4].Value = find.SelectSingleNode("Lop").InnerText;
                dataGridView1.Rows[0].Cells[5].Value = find.SelectSingleNode("NgayDK").InnerText;
            }
            }
        private void LoadComboBoxData()
        {

            comboBox1.Items.Add("Toàn bộ");

            doc.Load(filename);
            QLHS = doc.DocumentElement;
            XmlNodeList khoaList = QLHS.SelectNodes("SV");

            HashSet<string> uniqueValues = new HashSet<string>();

            foreach (XmlNode node in khoaList)
            {
                string lopValue = node.SelectSingleNode("Lop").InnerText;
                if (!uniqueValues.Contains(lopValue))
                {
                    comboBox1.Items.Add(lopValue);
                    uniqueValues.Add(lopValue);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            XmlNodeList node = QLHS.SelectNodes($"SV[Lop='{selected}']");
            int sd = 0;
            if (node != null)
            {
                dataGridView1.Rows.Clear();
                foreach (XmlNode item in node)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[sd].Cells[0].Value = item.SelectSingleNode("@MaSV").Value;
                    dataGridView1.Rows[sd].Cells[1].Value = item.SelectSingleNode("TenSV").InnerText;
                    dataGridView1.Rows[sd].Cells[2].Value = item.SelectSingleNode("Gioitinh").InnerText;
                    dataGridView1.Rows[sd].Cells[3].Value = item.SelectSingleNode("Diachi").InnerText;
                    dataGridView1.Rows[sd].Cells[4].Value = item.SelectSingleNode("Lop").InnerText;
                    dataGridView1.Rows[sd].Cells[5].Value = item.SelectSingleNode("NgayDK").InnerText;
                    sd++;
                }
            }
            if (selected == "Toàn bộ")
            {
                Hienthi(dataGridView1);
            }
        }
    }
}
