using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Match_the_following
{
    public partial class Form1 : Form
    {
        public int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton10.Checked == true)
            {
                i = i + 1;
                radioButton1.Enabled = false;
                radioButton10.Enabled = false;
            }
            if (radioButton1.Checked == true && radioButton7.Checked == true)
            {
                radioButton7.Enabled = false;
                radioButton1.Enabled = false;
            }
            if (radioButton1.Checked == true && radioButton8.Checked == true)
            {
                radioButton8.Enabled = false;
                radioButton1.Enabled = false;
            }
            if (radioButton1.Checked == true && radioButton9.Checked == true)
            {
                radioButton9.Enabled = false;
                radioButton1.Enabled = false;
            }
            if (radioButton1.Checked == true && radioButton6.Checked == true)
            {
                radioButton6.Enabled = false;
                radioButton1.Enabled = false;
            }
            if (radioButton2.Checked == true && radioButton8.Checked == true)
            {
                i = i + 1;
                radioButton2.Enabled = false;
                radioButton8.Enabled = false;
            }
            if (radioButton2.Checked == true && radioButton7.Checked == true)
            {
                radioButton7.Enabled = false;
                radioButton2.Enabled = false;
            }
            if (radioButton2.Checked == true && radioButton10.Checked == true)
            {
                radioButton10.Enabled = false;
                radioButton2.Enabled = false;
            }
            if (radioButton2.Checked == true && radioButton9.Checked == true)
            {
                radioButton9.Enabled = false;
                radioButton2.Enabled = false;
            }
            if (radioButton2.Checked == true && radioButton6.Checked == true)
            {
                radioButton6.Enabled = false;
                radioButton2.Enabled = false;
            }
            if (radioButton3.Checked == true && radioButton7.Checked == true)
            {
                i = i + 1;
                radioButton3.Enabled = false;
                radioButton7.Enabled = false;
            }
            if (radioButton3.Checked == true && radioButton10.Checked == true)
            {
                radioButton10.Enabled = false;
                radioButton3.Enabled = false;
            }
            if (radioButton3.Checked == true && radioButton8.Checked == true)
            {
                radioButton8.Enabled = false;
                radioButton3.Enabled = false;
            }
            if (radioButton3.Checked == true && radioButton9.Checked == true)
            {
                radioButton9.Enabled = false;
                radioButton3.Enabled = false;
            }
            if (radioButton3.Checked == true && radioButton6.Checked == true)
            {
                radioButton6.Enabled = false;
                radioButton3.Enabled = false;
            }
            if (radioButton4.Checked == true && radioButton6.Checked == true)
            {
                i = i + 1;
                radioButton4.Enabled = false;
                radioButton6.Enabled = false;
            }
            if (radioButton4.Checked == true && radioButton7.Checked == true)
            {
                radioButton7.Enabled = false;
                radioButton4.Enabled = false;
            }
            if (radioButton4.Checked == true && radioButton8.Checked == true)
            {
                radioButton8.Enabled = false;
                radioButton4.Enabled = false;
            }
            if (radioButton4.Checked == true && radioButton9.Checked == true)
            {
                radioButton9.Enabled = false;
                radioButton4.Enabled = false;
            }
            if (radioButton4.Checked == true && radioButton10.Checked == true)
            {
                radioButton10.Enabled = false;
                radioButton4.Enabled = false;
            }
            if (radioButton5.Checked == true && radioButton9.Checked == true)
            {
                i = i + 1;
                radioButton5.Enabled = false;
                radioButton9.Enabled = false;
            }
            if (radioButton5.Checked == true && radioButton7.Checked == true)
            {
                radioButton7.Enabled = false;
                radioButton5.Enabled = false;
            }
            if (radioButton5.Checked == true && radioButton8.Checked == true)
            {
                radioButton8.Enabled = false;
                radioButton5.Enabled = false;
            }
            if (radioButton5.Checked == true && radioButton10.Checked == true)
            {
                radioButton10.Enabled = false;
                radioButton5.Enabled = false;
            }
            if (radioButton5.Checked == true && radioButton6.Checked == true)
            {
                radioButton6.Enabled = false;
                radioButton5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = i.ToString();
            Thread.Sleep(1000);
            label5.Visible = true;
            
        }
    }
}
