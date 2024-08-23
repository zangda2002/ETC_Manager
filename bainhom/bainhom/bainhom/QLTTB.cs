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
using System.Xml.Linq;

namespace bainhom
{
    public partial class QLTTB : Form
    {
        public QLTTB()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        XmlElement sach;
        string filename = @"C:\Users\zangd\OneDrive\Máy tính\Project_V\bainhom\bainhom\bainhom\QLS.xml";
        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthi(dataGridView1);
            LoadComboBoxData();
        }
        public void Hienthi(DataGridView dataGridView1)
        {
            doc.Load(filename);
            sach = doc.DocumentElement;
            XmlNodeList ds = sach.SelectNodes("thongtinsach");
            int sd = 0;
            foreach (XmlNode node in ds)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sd].Cells[0].Value = node.SelectSingleNode("@mas").Value;
                dataGridView1.Rows[sd].Cells[1].Value = node.SelectSingleNode("capdo").InnerText;
                dataGridView1.Rows[sd].Cells[2].Value = node.SelectSingleNode("tensach").InnerText;
                dataGridView1.Rows[sd].Cells[3].Value = node.SelectSingleNode("soluong").InnerText;
                dataGridView1.Rows[sd].Cells[4].Value = node.SelectSingleNode("gia").InnerText;
                dataGridView1.Rows[sd].Cells[5].Value = node.SelectSingleNode("nhaxuatban").InnerText;
                sd++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ms.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ts.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            sl.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            gia.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            nxb.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            sach = doc.DocumentElement;
            XmlNode ppl = doc.CreateElement("thongtinsach");
            XmlAttribute ma = doc.CreateAttribute("mas");
            ma.InnerText = ms.Text;
            ppl.Attributes.Append(ma);
            XmlElement lv = doc.CreateElement("capdo");
            lv.InnerText = cd.Text;
            ppl.AppendChild(lv);
            XmlElement ten = doc.CreateElement("tensach");
            ten.InnerText = ts.Text;
            ppl.AppendChild(ten);
            XmlElement soluong= doc.CreateElement("soluong");
            soluong.InnerText = sl.Text;
            ppl.AppendChild(soluong);
            XmlElement gt = doc.CreateElement("gia");
            gt.InnerText = gia.Text;
            ppl.AppendChild(gt);
            XmlElement nhaxb= doc.CreateElement("nhaxuatban");
            nhaxb.InnerText = nxb.Text;
            ppl.AppendChild(nhaxb);
            capdo.Items.Add(cd.Text);
            sach.AppendChild(ppl);
            doc.Save(filename);
            Hienthi(dataGridView1);
        }

        private void sua_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            sach = doc.DocumentElement;
            XmlNode find = sach.SelectSingleNode("thongtinsach[@mas='" + ms.Text + "']");
            if (find != null)
            {
                XmlNode ppl = doc.CreateElement("thongtinsach");
                XmlAttribute ma = doc.CreateAttribute("mas");
                ma.InnerText = ms.Text;
                ppl.Attributes.Append(ma);
                XmlElement ten = doc.CreateElement("tensach");
                ten.InnerText = ts.Text;
                ppl.AppendChild(ten);
                XmlElement soluong = doc.CreateElement("soluong");
                soluong.InnerText = sl.Text;
                ppl.AppendChild(soluong);
                XmlElement gt = doc.CreateElement("gia");
                gt.InnerText = gia.Text;
                ppl.AppendChild(gt);
                XmlElement nhaxb = doc.CreateElement("nhaxuatban");
                nhaxb.InnerText = nxb.Text;
                ppl.AppendChild(nhaxb);
                XmlElement lv = doc.CreateElement("capdo");
                lv.InnerText = cd.Text;
                ppl.AppendChild(lv);
                capdo.Items.Add(cd.Text);
                sach.ReplaceChild(ppl, find);
                doc.Save(filename);
                Hienthi(dataGridView1);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            sach = doc.DocumentElement;
            XmlNode find = sach.SelectSingleNode("thongtinsach[@mas='" + ms.Text + "']");
            if (find != null)
            {
                sach.RemoveChild(find);
                doc.Save(filename);
            }
            dataGridView1.Rows.Clear();
            Hienthi(dataGridView1);
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            sach = doc.DocumentElement;
            XmlNode find = sach.SelectSingleNode("thongtinsach[@mas='" + ms.Text + "']");
            if (find != null)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows[0].Cells[0].Value = find.SelectSingleNode("@mas").Value;
                dataGridView1.Rows[0].Cells[1].Value = find.SelectSingleNode("capdo").InnerText;
                dataGridView1.Rows[0].Cells[2].Value = find.SelectSingleNode("tensach").InnerText;
                dataGridView1.Rows[0].Cells[3].Value = find.SelectSingleNode("soluong").InnerText;
                dataGridView1.Rows[0].Cells[4].Value = find.SelectSingleNode("gia").InnerText;
                dataGridView1.Rows[0].Cells[5].Value = find.SelectSingleNode("nhaxuatban").InnerText;
            }
        }
        private void LoadComboBoxData()
        {
            capdo.Items.Add("Tất cả");

            doc.Load(filename);
            sach = doc.DocumentElement;
            XmlNodeList khoaList = sach.SelectNodes("thongtinsach");

            HashSet<string> uniqueValues = new HashSet<string>();

            foreach (XmlNode node in khoaList)
            {
                string lopValue = node.SelectSingleNode("capdo").InnerText;
                if (!uniqueValues.Contains(lopValue))
                {
                    capdo.Items.Add(lopValue);
                    uniqueValues.Add(lopValue);
                }
            }
        }

        private void capdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = capdo.SelectedItem.ToString();
            XmlNodeList node = sach.SelectNodes($"thongtinsach[capdo='{selected}']");
            int sd = 0;
            if (node != null)
            {
                dataGridView1.Rows.Clear();
                foreach (XmlNode item in node)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = item.SelectSingleNode("@mas").Value;
                    dataGridView1.Rows[0].Cells[1].Value = item.SelectSingleNode("capdo").InnerText;
                    dataGridView1.Rows[0].Cells[2].Value = item.SelectSingleNode("tensach").InnerText;
                    dataGridView1.Rows[0].Cells[3].Value = item.SelectSingleNode("soluong").InnerText;
                    dataGridView1.Rows[0].Cells[4].Value = item.SelectSingleNode("gia").InnerText;
                    dataGridView1.Rows[0].Cells[5].Value = item.SelectSingleNode("nhaxuatban").InnerText;
                    sd++;
                }
            }
            if (selected == "Tất cả")
            {
                Hienthi(dataGridView1);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Hienthi(dataGridView1);
            LoadComboBoxData();
        }
    }
}
