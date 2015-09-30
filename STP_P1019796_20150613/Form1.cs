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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { checkBox1.ForeColor = Color.Lime; }
            else
            { checkBox1.ForeColor = Color.White; }

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button1.Enabled = true;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////

        Add_1 add_01 = new Add_1();
        private void button1_Click(object sender, EventArgs e)
        {
            
                        if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                        {
                            add_01.Show();
                            this.Hide();
                        }
                        else
                        { MessageBox.Show(new Form() { TopMost = true }, "You have to fill up all the gaps before move on SUBMIT button.",
                                  "NOTICE | ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            /*

                        StudentDatabase.AddStudent(textBox1.Text, textBox2.Text, textBox3.Text);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        this.Signup_Load(this, null);
             */
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            { textBox1.BackColor = Color.Lime; }
            else
            { textBox1.BackColor = Color.White; }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox2.Text != "")
            { textBox2.BackColor = Color.Lime; }
            else
            { textBox2.BackColor = Color.White; }
             
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox3.Text != "")
            { textBox3.BackColor = Color.Lime; }
            else
            { textBox3.BackColor = Color.White; }
             
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void Signup_Load(object sender, EventArgs e)
        {
            /*
            listView1.Items.Clear();
            List<Student> studentList;
            try 
            {
                studentList = StudentDatabase.GetStudent();
                if (studentList.Count > 0) 
                {
                    Student student;
                    for (int i = 0; i < studentList.Count; i++ )
                    {
                        student = studentList[i];
                        listView1.Items.Add(student.ID.ToString());
                        listView1.Items[i].SubItems.Add(student.FirstName);
                        listView1.Items[i].SubItems.Add(student.LastName);
                        listView1.Items[i].SubItems.Add(student.StudentNumber);
                    }
                }
                else { MessageBox.Show("THERE ARE NO PARTICIPANT.", "Alert"); }
            }
            catch ( Exception ex ) { MessageBox.Show(ex.Message, ex.GetType().ToString());}
             */ 
        }
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////



