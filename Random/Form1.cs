using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        int a, b, c;
        int czas;
        bool active;
        public Form1()
        {
            InitializeComponent();
        }

        private void odile_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void doile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            czas = 0;
            active = true;
            Image img1 = Image.FromFile("img2.gif");
            pictureBox1.Image = img1;
            label2.Text = ("");

            Random random = new Random();

            a = int.Parse(odile.Text);
            b = int.Parse(doile.Text);
            c = random.Next(a, b+1);

            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (active)
            {
                czas++;
                
                if(czas==75)
                {
                    label2.Text = c.ToString();
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
                
            
        }
    }
}
