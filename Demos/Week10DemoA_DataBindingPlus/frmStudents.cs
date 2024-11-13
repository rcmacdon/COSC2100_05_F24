using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week10DemoA_DataBindingPlus.Classes;

namespace Week10DemoA_DataBindingPlus
{
    public partial class frmStudents : Form
    {

        private bool isLoading = true;

        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmSplash frm = new frmSplash(this);
            frm.ShowDialog();

            Student.PopulateStudents();
            studentBindingSource.DataSource = Student.students;

            isLoading = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                Student student = (Student)comboBox1.SelectedItem;
                if (student != null)
                {
                    lblFirstName.Text = student.FirstName;
                    lblLastName.Text = student.LastName;
                    lblAge.Text = student.Age.ToString();
                    lblFullName.Text = student.FullName;
                    ssLblCurrentStudent.Text = student.ToString();
                } else
                {
                    lblFirstName.Text = string.Empty;
                    lblLastName.Text = string.Empty;
                    lblAge.Text = string.Empty;
                    lblFullName.Text = string.Empty;
                    ssLblCurrentStudent.Text = "- none -";
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                if (comboBox1.SelectedIndex > 0) comboBox1.SelectedIndex--;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(comboBox1.Items.Count > 0)
            {
                if (comboBox1.SelectedIndex < comboBox1.Items.Count - 1) comboBox1.SelectedIndex++;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                Student student = (Student)comboBox1.SelectedItem;
                Student.students.Remove(student);
                comboBox1.SelectedIndex = 0;

                studentBindingSource.ResetBindings(false);
            }
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            frmEmployees frm = new frmEmployees();
            frm.ShowDialog();
        }
    }
}
