using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STP_P1019796_20150613
{
    public partial class BasicCalculator : Form
    {
        public BasicCalculator()
        {
            InitializeComponent();
        }

        Double Firstnumber; 
        int OperatorID;

////////////////////////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
                textBox1.Text = textBox1.Text + "1";
            if (display.Text == "0")
            {
                display.Text = "1";
            }
            else
                display.Text = display.Text + "1";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
                textBox1.Text = textBox1.Text + "2";
            if (display.Text == "0")
            {
                display.Text = "2";
            }
            else
                display.Text = display.Text + "2";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
                textBox1.Text = textBox1.Text + "3";
            if (display.Text == "0")
            {
                display.Text = "3";
            }
            else
                display.Text = display.Text + "3";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
                textBox1.Text = textBox1.Text + "4";
            if (display.Text == "0")
            {
                display.Text = "4";
            }
            else
                display.Text = display.Text + "4";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
                textBox1.Text = textBox1.Text + "5";
            if (display.Text == "0")
            {
                display.Text = "5";
            }
            else

                display.Text = display.Text + "5";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
                textBox1.Text = textBox1.Text + "6";
            if (display.Text == "0")
            {
                display.Text = "6";
            }
            else
                display.Text = display.Text + "6";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
                textBox1.Text = textBox1.Text + "7";
            if (display.Text == "0")
            {
                display.Text = "7";
            }
            else
                display.Text = display.Text + "7";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
                textBox1.Text = textBox1.Text + "8";
            if (display.Text == "0")
            {
                display.Text = "8";
            }
            else
                display.Text = display.Text + "8";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
                textBox1.Text = textBox1.Text + "9";
            if (display.Text == "0")
            {
                display.Text = "9";
            }
            else
                display.Text = display.Text + "9";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button10_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
                textBox1.Text = textBox1.Text + "0";
            if (display.Text == "0")
            {
                display.Text = "0";
            }
            else
                display.Text = display.Text + "0";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            OperatorID = 1;
            if (display.Text == "0")
            {
                display.Text = "0";
            }
            else
                display.Text = display.Text + "+";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonSub_Click(object sender, EventArgs e)
        {
            Firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            OperatorID = 2;
            if (display.Text == "0")
            {
                display.Text = "0";
            }
            else
                display.Text = display.Text + "-";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            OperatorID = 3;
            if (display.Text == "0")
            {
                display.Text = "0";
            }
            else
                display.Text = display.Text + "x";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            OperatorID = 4;
            if (display.Text == "0")
            {
                display.Text = "0";
            }
            else
                display.Text = display.Text + "÷";
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonSq_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && textBox1.Text == "0")
            {
                display.Text = "0";
                textBox1.Text = "0";
            }
            else
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 
                    Convert.ToDouble(textBox1.Text));
            display.Text = display.Text + "sq = " + textBox1.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            buttonAdd.Enabled = false;
            buttonSub.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonDivide.Enabled = false;
            buttonPercent.Enabled = false;
            buttonEqual.Enabled = false;
            buttonSq.Enabled = false;
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && textBox1.Text == "0")
            {
                display.Text = "0";
                textBox1.Text = "0";
            }
            else
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Firstnumber / 100);
            display.Text = display.Text + "% = " + textBox1.Text;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            buttonAdd.Enabled = false;
            buttonSub.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonDivide.Enabled = false;
            buttonSq.Enabled = false;
            buttonEqual.Enabled = false;
            buttonPercent.Enabled = false;
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (OperatorID)
            {
                case 0:
                    textBox1.Text = "0";
                    break;
                case 1:
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Firstnumber);
                    display.Text = display.Text + " = " + textBox1.Text;
                    break;

                case 2:
                    textBox1.Text = Convert.ToString(Firstnumber - Convert.ToDouble(textBox1.Text));
                    display.Text = display.Text + " = " + textBox1.Text;
                    break;

                case 3:
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Firstnumber);
                    display.Text = display.Text + " = " + textBox1.Text;
                    break;

                case 4:
                    textBox1.Text = Convert.ToString(Firstnumber / Convert.ToDouble(textBox1.Text));
                    display.Text = display.Text + " = " + textBox1.Text;
                    break;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            buttonAdd.Enabled = false;
            buttonSub.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonDivide.Enabled = false;
            buttonSq.Enabled = false;
            buttonPercent.Enabled = false;
            buttonEqual.Enabled = false;
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            display.Text = "0";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            buttonAdd.Enabled = true;
            buttonSub.Enabled = true;
            buttonMultiply.Enabled = true;
            buttonDivide.Enabled = true;
            buttonSq.Enabled = true;
            buttonPercent.Enabled = true;
            buttonEqual.Enabled = true;
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
////////////////////////////////////////////////////////////////////////////////////////////////
        Level_1 level01 = new Level_1();
        private void button11_Click(object sender, EventArgs e)
        {
            level01.Show();
            this.Hide();
        }
    }
}
////////////////////////////////////////////////////////////////////////////////////////////////