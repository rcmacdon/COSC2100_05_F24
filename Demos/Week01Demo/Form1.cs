using System;
using System.Windows.Forms;

namespace Week01Demo
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hi Clint", "Clint was Here", MessageBoxButtons.YesNoCancel);

            if (dr == DialogResult.Yes) btnHelloWorld.Text = "Yeah!";
            else if (dr == DialogResult.No) btnHelloWorld.Text = "Nah!";
            else btnHelloWorld.Text = "No Way Jose!";

        }
    }
}
