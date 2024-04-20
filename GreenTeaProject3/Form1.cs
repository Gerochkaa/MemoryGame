using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GreenTeaProject3
{
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (NameBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your nickname.");
            }
            else
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            //if (comboBox1.Items.Equals(3))
            //{
            //    int size = Convert.ToInt32(textBox2.Text);
            //    FileStream fs1 = new FileStream("Size.txt", FileMode.Create, FileAccess.Write);
            //    StreamWriter sw1 = new StreamWriter(fs1);
            //    sw1.Write(size);
            //    sw1.Close();
            //    fs1.Close();
            //    String name;
            //    name = NameBox.Text;
            //    FileStream fs = new FileStream("Nickname.txt", FileMode.Create, FileAccess.Write);
            //    StreamWriter sw = new StreamWriter(fs);
            //    sw.Write(name);
            //    sw.Close();
            //    fs.Close();
            //    Form2 f2 = new Form2();
            //    this.Hide();
            //    f2.Show();
            //}
            //else
            //{
            //    this.Hide();
            //    Form2 f2 = new Form2();
            //    f2.Show();
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                Data.Values = 4;
                Data.Rows = 3;
                Data.Columns = 3;
                Data.Lives = 3;
                Data.Tiles = 4;
                Data.Time = 20;
            }

            if (comboBox1.SelectedIndex.Equals(1))
            {
                Data.Values = 6;
                Data.Rows = 4;
                Data.Columns = 4;
                Data.Lives = 2;
                Data.Tiles = 6;
                Data.Time = 15;
            }

            if (comboBox1.SelectedIndex.Equals(2))
            {
                Data.Values = 8;
                Data.Rows = 5;
                Data.Columns = 5;
                Data.Lives = 1;
                Data.Tiles = 8;
                Data.Time = 10;
            }

            if (comboBox1.Items.Equals(3))
            {
                int size = Convert.ToInt32(textBox2.Text);
                FileStream fs1 = new FileStream("Size.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw1 = new StreamWriter(fs1);
                sw1.Write(size);
                sw1.Close();
                fs1.Close();
                String name;
                name = NameBox.Text;
                FileStream fs = new FileStream("Nickname.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(name);
                sw.Close();
                fs.Close();
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            //else
            //{
            //    this.Hide();
            //    Form2 f2 = new Form2();
            //    f2.Show();
            //}
        }
    }
}
