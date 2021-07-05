using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFormDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //figure out the major

            string major = "TBD";

            if (programmingRadioButton.Checked)
            {
                major = programmingRadioButton.Text;
            }
            else if (webDesignRadioButton.Checked)
            {
                major = webDesignRadioButton.Text;
            }
            else if(itRadioButton.Checked)
            {
                major = itRadioButton.Text;
            }

            //instantiate a student

            Student st = new Student(studentIDTextBox.Text,
                                    firstNameTextBox.Text,
                                    lastNameTextBox.Text,
                                    major);

            st.StudentNumber = studentIDTextBox.Text;

            //count check boxes
            int count = 0;
            if (cis101CheckBox.Checked)
            {
                count++;
            }
            if (cis102CheckBox.Checked)
            {
                count++;
            }
            if (cis103CheckBox.Checked)
            {
                count++;
            }
            if (cis104CheckBox.Checked)
            {
                count++;
            }

            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;

            if (cis101CheckBox.Checked)
            {
                courses[index] = cis101CheckBox.Text;
                scores[index++] = Convert.ToInt32(score1TextBox.Text);
            }
            if (cis102CheckBox.Checked)
            {
                courses[index] = cis102CheckBox.Text;
                scores[index++] = Convert.ToInt32(score2TextBox.Text);
            }
            if (cis103CheckBox.Checked)
            {
                courses[index] = cis103CheckBox.Text;
                scores[index++] = Convert.ToInt32(score3TextBox.Text);
            }
            if (cis104CheckBox.Checked)
            {
                courses[index] = cis104CheckBox.Text;
                scores[index++] = Convert.ToInt32(score4TextBox.Text);
            }

            //set arrays into student object
            st.Scores = scores;
            st.Courses = courses;

            //display output

            string summary =
                "Student's Major is " + st.Major +
                "\r\nStudent First Name: " + st.FirstName +
                "\r\nStudent Last Name: " + st.LastName +
                "\r\nStudent Average: " + st.Average +
                "\r\nCourses: ";
            foreach(string course in courses)
            {
                summary += "\r\n" + course;
            }
            resultTextBox.Text = summary;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.course.com");
            linkLabel1.LinkVisited = true;
        }
    }
}
