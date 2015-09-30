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
    public partial class Level_1 : Form
    {
        public Level_1()
        {
            InitializeComponent();
        }
        int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int count = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonNext.Enabled = false;
            count -= 1;
            textBoxTimer.Text = count.ToString();
            if (count == 0)
            {
                timer1.Stop();
                MessageBox.Show(new Form() { TopMost = true }, "Your time is up! \n But don't be dishearted. \n You are doing well. \n Just press OK, then press START \n to get another set of random numbers for quizzes",
                    "NOTICE | TIME'S UP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                answer1.Text = ""; answer1.Enabled = true; answer1.ReadOnly = false;
                answer2.Text = ""; answer2.Enabled = true; answer2.ReadOnly = false;
                answer3.Text = ""; answer3.Enabled = true; answer3.ReadOnly = false;
                answer4.Text = ""; answer4.Enabled = true; answer4.ReadOnly = false;
                answer5.Text = ""; answer5.Enabled = true; answer5.ReadOnly = false;
                buttonStrat.Enabled = true;
                buttonCheck.Enabled = false;
                buttonNext.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBoxTimer.BackColor = Color.Green;
                textBoxTimer.ForeColor = Color.LightGray;
                pictureBox_R1.Visible = false;
                pictureBox_R2.Visible = false;
                pictureBox_R3.Visible = false;
                pictureBox_R4.Visible = false;
                pictureBox_R5.Visible = false;
                pictureBox_W1.Visible = false;
                pictureBox_W2.Visible = false;
                pictureBox_W3.Visible = false;
                pictureBox_W4.Visible = false;
                pictureBox_W5.Visible = false;
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void textBoxTimer_TextChanged(object sender, EventArgs e)
        {
            if (count <= 10)
            {
                textBoxTimer.BackColor = Color.Red;
                textBoxTimer.ForeColor = Color.White;
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void buttonStrat_Click(object sender, EventArgs e)
        {
            buttonStrat.Enabled = false;
            buttonCheck.Enabled = true;

            System.Random random = new System.Random();

            num1 = random.Next(10, 15);
            textBox1.Text = num1.ToString();

            num2 = random.Next(25, 30);
            textBox2.Text = num2.ToString();

            num3 = random.Next(31, 36);
            textBox3.Text = num3.ToString();

            num4 = random.Next(45, 55);
            textBox4.Text = num4.ToString();

            num5 = random.Next(37, 41);
            textBox5.Text = num5.ToString();

            num6 = random.Next(56, 60);
            textBox6.Text = num6.ToString();

            num7 = random.Next(42, 50);
            textBox7.Text = num7.ToString();

            num8 = random.Next(56, 65);
            textBox8.Text = num8.ToString();

            num9 = random.Next(66, 72);
            textBox9.Text = num9.ToString();

            num10 = random.Next(85, 90);
            textBox10.Text = num10.ToString();

            count = 60;
            timer1.Start();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if ((answer1.Text != "") && (answer2.Text != "") && (answer3.Text != "") && 
                (answer4.Text != "") && (answer5.Text != ""))
            {
                int ans1 = Convert.ToInt32(answer1.Text);
                int ans2 = Convert.ToInt32(answer2.Text);
                int ans3 = Convert.ToInt32(answer3.Text);
                int ans4 = Convert.ToInt32(answer4.Text);
                int ans5 = Convert.ToInt32(answer5.Text);
                ////////////////////////////////////////////////////////////////////////////////////////
                if ((num1 + ans1) != (num2))
                {
                    pictureBox_W1.Visible = true;
                    answer1.Enabled = true;
                    answer1.Text = "";
                }
                else
                {
                    pictureBox_R1.Visible = true;
                    answer1.ReadOnly = true;
                }
                if ((num1 + ans1 == num2) && (pictureBox_W1.Visible = true))
                {
                    pictureBox_R1.Visible = true;
                    pictureBox_W1.Hide();
                    answer1.ReadOnly = true;
                }
                else
                {
                    pictureBox_W1.Visible = true;
                }
                //////////////////////////////////////////////////////////////////////////////////////////
                if ((ans2 + num3) != num4)
                {
                    pictureBox_W2.Visible = true;
                    answer2.Enabled = true;
                    answer2.Text = "";
                }
                else
                {
                    pictureBox_R2.Visible = true;
                    answer2.ReadOnly = true;
                }
                if ((num3 + ans2 == num4) && (pictureBox_W2.Visible = true))
                {
                    pictureBox_R2.Visible = true;
                    pictureBox_W2.Hide();
                    answer2.ReadOnly = true;
                }
                else
                {
                    pictureBox_W2.Visible = true;
                }
                ////////////////////////////////////////////////////////////////////////////////////////
                if ((num5 + ans3) != num6)
                {
                    pictureBox_W3.Visible = true;
                    answer3.Enabled = true;
                    answer3.Text = "";
                }
                else
                {
                    pictureBox_R3.Visible = true;
                    answer3.ReadOnly = true;
                }
                if ((num5 + ans3 == num6) && (pictureBox_W3.Visible = true))
                {
                    pictureBox_R3.Visible = true;
                    pictureBox_W3.Hide();
                    answer3.ReadOnly = true;
                }
                else
                {
                    pictureBox_W3.Visible = true;
                }
                ////////////////////////////////////////////////////////////////////////////////////////
                if ((num7 + ans4) != num8)
                {
                    pictureBox_W4.Visible = true;
                    answer4.Enabled = true;
                    answer4.Text = "";
                }
                else
                {
                    pictureBox_R4.Visible = true;
                    answer4.ReadOnly = true;
                }
                if ((num7 + ans4 == num8) && (pictureBox_W4.Visible = true))
                {
                    pictureBox_R4.Visible = true;
                    pictureBox_W4.Hide();
                    answer4.ReadOnly = true;
                }
                else
                {
                    pictureBox_W4.Visible = true;
                }
                ////////////////////////////////////////////////////////////////////////////////////////
                if ((ans5 + num9) != num10)
                {
                    pictureBox_W5.Visible = true;
                    answer5.Enabled = true;
                    answer5.Text = "";
                }
                else
                {
                    pictureBox_R5.Visible = true;
                    answer5.ReadOnly = true;
                }
                if ((num9 + ans5 == num10) && (pictureBox_W5.Visible = true))
                {
                    pictureBox_R5.Visible = true;
                    pictureBox_W5.Hide();
                    answer5.ReadOnly = true;
                }
                else
                {
                    pictureBox_W5.Visible = true;
                }
                ////////////////////////////////////////////////////////////////////////////////////////
                if (((num1 + ans1) == num2) && ((ans2 + num3) == num4) && ((num5 + ans3) == num6) && 
                    ((num7 + ans4) == num8) && ((ans5 + num9) == num10))
                {
                    timer1.Stop();
                    MessageBox.Show(new Form() { TopMost = true }, "            ! ! ! GREAT JOB ! ! ! \n  ! ! ! YOU MADE ALL CORRECT ! ! !",
                    "CONGRATULATIONS ON SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonNext.Enabled = true;
                    buttonCheck.Enabled = false;
                }
                else
                {
                    MessageBox.Show(new Form() { TopMost = true }, "We appreciate your effort. \nYou are doing well. \nBut you need a little bit more concentration \nto correct your wrong answer. \n Just press OK and try it again.",
                    "NOTICE | CORRECTION NEEDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonCheck.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(new Form() { TopMost = true }, "     Oh! darling, You have to complete all quizzes \n     before press CHECK button.",
                    "NOTICE | COMPLETE THE QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        Level_2 level02 = new Level_2();
        private void buttonNext_Click(object sender, EventArgs e)
        {
            level02.Show();
            this.Hide();
        }
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////