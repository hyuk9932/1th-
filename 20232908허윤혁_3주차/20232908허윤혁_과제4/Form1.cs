using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20232908허윤혁_과제4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idata01 = int.Parse(textBox1.Text);
            int idata02 = int.Parse(textBox2.Text);
           int idata03 = idata01 / idata02;
           int idata04 = idata01 % idata02;
 
                label2.Text = idata01 + "나누기" + idata02 + "의 몫은" + idata03 + "이고 나머지는" +  idata04  +  "입니다" ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text  = "결과가 나오는곳";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
