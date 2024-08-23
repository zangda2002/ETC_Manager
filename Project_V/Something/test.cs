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
namespace Project_V.Something
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        string filename = @"C:\Users\zangd\OneDrive\Máy tính\Project_V\Project_V\Something\test.xml";
        XmlDocument doc= new XmlDocument();
        XmlElement qltest;

        public void show(DataGridView dgv)
        {
            doc.Load(filename);
            qltest = doc.DocumentElement;
            XmlNodeList xmlnode = qltest.SelectNodes("QLSomething");
            int sd = 0;
            foreach(XmlNode item in xmlnode)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("@id").Value;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("ten").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("address").InnerText;
                sd++;
            }
    }

        private void test_Load(object sender, EventArgs e)
        {
            show(dgv);
        }
    }

   
}
