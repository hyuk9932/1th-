using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20232908허윤혁_과제3
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             int idata01 = int.Parse (textBox1.Text);
             int idata02 = int.Parse (textBox2.Text);
             int idata03 = int.Parse (textBox3.Text);

             int idata04 = idata01 * 10 * idata02 * 10 * idata03 * 10;

             label7.Text = "직육면체 가로 : " + idata01 * 10 +  "mm세로 : " + idata02 * 10  + "mm높이 :" + idata03 * 10  +"mm 의 \n부피는" + idata04 + "입니다";
            
             
             }

            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idata05 = int.Parse(textBox1.Text);
                int idata06 = int.Parse(textBox2.Text);
                int idata07 = int.Parse(textBox3.Text);

                int idata08 = idata05 *   idata06  * idata07 ;

                label7.Text = "직육면체 가로 : " + idata05   + "cm세로 : " + idata06   + "cm높이 :" + idata07   + "cm 의 \n부피는" + idata08 + "입니다";


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
                double idata09 = double.Parse(textBox1.Text);
                double idata10 = double.Parse(textBox2.Text);
                double idata11 = double.Parse(textBox3.Text);

                double idata12 = idata09 * 100 * idata10 * 100 * idata11 * 100; 

                label7.Text = "직육면체 가로 : " + idata09 + "m세로 : " + idata10 + "m높이 :" + idata11 + "m 의 \n부피는" + idata12 + "입니다";


            }

            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "" ;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
