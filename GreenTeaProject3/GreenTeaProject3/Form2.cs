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
        int SecondsNow = 15;
        int SecondsLeft = 15;
        private bool game = false;

        public Form2()
        {
            InitializeComponent();
        }
        private int size;
        public Form2(int size)
        {
            this.size = size;
        }


        int column;
            int row;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Nickname.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Nickname.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            FileStream fs1 = new FileStream("Size.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs1);
            int Size = Convert.ToInt32(sr1.ReadToEnd());
            sr1.Close();
            fs1.Close();
            row = Size;
            column = Size;
            int x = 170;
            int y = 20;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            game = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = SecondsLeft--.ToString();                 
            if (SecondsLeft < 0)
            {
                timer1.Stop();
                groupBox1.Enabled = true;
                game = false;                                            
                button1.Enabled = true;

                MessageBox.Show("You finished this game in " + SecondsLeft + "GAME OVER");

            }
        }
    }
}

