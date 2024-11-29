using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12DemoB_MDIForms_Singleton
{
    public partial class frmSubForm : Form
    {
        public frmSubForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBrother frm = new frmBrother();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1.myString = textBox1.Text;

            Form1 frm = (Form1)this.MdiParent;
            frm.ts.Text = Form1.myString;
        }
    }
}
