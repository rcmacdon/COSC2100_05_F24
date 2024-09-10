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
            if ( MessageBox.Show("Hi Clint", "Clint was Here",MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                btnHelloWorld.Text = "Yeah!";
            };

        }
    }
}
