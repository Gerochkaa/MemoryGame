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
        }
    }
}
