using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void make_round(Button button)
        {

            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, button.Width - 4, button.Height - 4);
            button.Region = new Region(p);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //make_round(button8);
            //make_round(button9);
            //make_round(button10);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //make_round(button8);
            //make_round(button9);
            //make_round(button10);
        }

        private void Show_mes(Button button)
        {
            MessageBox.Show(button.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Show_mes(sender as Button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show_mes(sender as Button);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show_mes(sender as Button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Show_mes(sender as Button);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Show_mes(sender as Button);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Show_mes(sender as Button);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Show_mes(sender as Button);
        }
    }
}
