using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week09DemoB_FileIO
{
    public partial class Form1 : Form
    {

        String saveContent = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv";
            openFileDialog1.Title = "Open a file";
            openFileDialog1.FileName = txtFileName.Text;
            openFileDialog1.ShowDialog();
            txtFileName.Text = openFileDialog1.FileName;

            try
            {
                rtbContent.Text = MyFiles.ReadFromFile(txtFileName.Text);
                saveContent = rtbContent.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error reading file");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MyFiles.WriteToFile(txtFileName.Text, rtbContent.Text);
                saveContent = rtbContent.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error writing file");
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv";
            saveFileDialog1.Title = "Save a file";
            saveFileDialog1.FileName = txtFileName.Text;
            saveFileDialog1.ShowDialog();
            txtFileName.Text = saveFileDialog1.FileName;

            btnSave_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rtbContent.Text != saveContent)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    btnSave_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
