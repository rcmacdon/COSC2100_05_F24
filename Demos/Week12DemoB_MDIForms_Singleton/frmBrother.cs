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
    public partial class frmBrother : Form
    {
        public frmBrother()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBrother_Activated(object sender, EventArgs e)
        {
            label1.Text = Form1.myString;
        }
    }
}
