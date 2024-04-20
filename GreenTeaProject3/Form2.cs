using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace GreenTeaProject3
{
    public partial class Form2 : Form
    {
        double time = Data.Time;
        double SecondsLeft = 0;
        int LivesExist, ValuesNumber; //LivesExist = count of lives, ValuesNumber = number of numbers in textboxes

        public Form2()
        {
            InitializeComponent();
            label2.Text = time.ToString();
        }
        private int size;
        public Form2(int size)
        {
            this.size = size;
        }


        int column;
        int row;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SecondsLeft = SecondsLeft + 0.1;
            label2.Text = SecondsLeft.ToString("0.0");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("Nickname.txt", FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fs);
            //Nickname.Text = sr.ReadToEnd();
            //sr.Close();
            //fs.Close();

            //else
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

            ValuesNumber = Data.Values;
            LivesExist = Data.Lives;
            row = Data.Rows;
            column = Data.Columns;
            time = Data.Time;
            label7.Text = "" + Data.Tiles;
            label6.Text = "" + LivesExist;
            int x = 170, y = 20;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {

                    TextBox tb = new TextBox();


                    tb.Name = $"tb{i}{j}";
                    tb.Text = "";
                    tb.Font = new Font("Arial", 20);
                    tb.Location = new Point(x, y);
                    tb.Height = 10;
                    tb.Width = 40;


                    this.Controls.Add(tb);

                    x += 50;
                }

                y += 40;
                x = 170;
            }
        }
    }
}
