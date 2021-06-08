using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HW2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XMLreader();
        }
        void XMLreader()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("XMLFile1.xml");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DataSet d = new DataSet();
            d.ReadXml("XMLFile1.xml");
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    var selectedMinerals1 = d.Tables[0].Select("color='Colorless'");
                    foreach (var item in selectedMinerals1) listBox1.Items.Add(item["name"]);
                    break;
                case 1:
                    var selectedMinerals2 = d.Tables[0].Select("color='Green'");
                    foreach (var item in selectedMinerals2) listBox1.Items.Add(item["name"]);
                    break;
                case 2:
                    var selectedMinerals3 = d.Tables[0].Select("color='Black'");
                    foreach (var item in selectedMinerals3) listBox1.Items.Add(item["name"]);
                    break;
                case 3:
                    var selectedMinerals4 = d.Tables[0].Select("color='Various'");
                    foreach (var item in selectedMinerals4) listBox1.Items.Add(item["name"]);
                    break;
            }
            
        }
    }
}
