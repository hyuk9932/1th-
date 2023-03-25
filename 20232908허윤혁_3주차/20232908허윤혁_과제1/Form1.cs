using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20232908허윤혁_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                int idata01 = int.Parse(textBox1.Text);
                int idata02 = int.Parse(textBox2.Text);
                int idata03 = idata02 + idata01;
                 label1.Text = "+";
                label2.Text = "결과는 " + idata03 + "입니다" ; 

            }
            catch (Exception ex)
            { 
            label2.Text = ex.Message ; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idata04 = int.Parse(textBox1.Text);
                int idata05 = int.Parse(textBox2.Text);
                int idata06 = idata04 - idata05;
                label1.Text = "-";
                label2.Text = "결과는 " + idata06 + "입니다";

            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             try 
            {
                int idata07 = int.Parse(textBox1.Text);
                int idata08 = int.Parse(textBox2.Text);
                int idata09 = idata07 * idata08;
                 label1.Text = "x";
                label2.Text = "결과는 " + idata09 + "입니다" ; 

            }
            catch (Exception ex)
            { 
            label2.Text = ex.Message ; 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double idata10 = double.Parse(textBox1.Text);
                double idata11 = double.Parse(textBox2.Text);
                double idata12 = idata10 / idata11;
                label1.Text = "/";
                label2.Text = "결과는 " + idata12 + "입니다";

            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
