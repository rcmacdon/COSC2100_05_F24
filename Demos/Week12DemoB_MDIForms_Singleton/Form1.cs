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
    public partial class Form1 : Form
    {

        public static string myString = "Hello World";
        public ToolStripLabel ts;

        public Form1()
        {
            InitializeComponent();
            ts = tsLblMyString;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubForm frm = new frmSubForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
