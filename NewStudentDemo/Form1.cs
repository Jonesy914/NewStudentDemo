using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewStudentDemo
{
    public partial class Form1 : Form
    {
        Student newStudent;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newStudent = new Student(txtName.Text, Convert.ToInt16(txtAge.Text));
            MessageBox.Show("Record created!");
            txtName.Clear();
            txtAge.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The student is: " + newStudent.Name + " and their age is: " + newStudent.Age);
        }
    }
}
