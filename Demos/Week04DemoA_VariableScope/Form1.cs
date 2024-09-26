using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04DemoA_VariableScope
{

    public partial class Form1 : Form
    {

        public const int Y = 15; // Global Scope (not truly)
        private const int X = 12; // Class Scope
        private static int W = 10; // Class Scope
        private int Z = 14; //  Class Scope (instance)

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            W = Tools.RandomInt(0, 255);
            label1.Text = W.ToString();

            Z = Tools.RandomInt(0, 255);
            label2.Text = Z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //W = Tools.RandomInt(0, 255);

            label1.Text = W.ToString();
            label2.Text = Z.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = W.ToString();
            label2.Text = Z.ToString();

            if (W > 128)
            {
                //label3.Text = W.ToString(); -- does not work
                int W = 20;
                label3.Text = W.ToString();
            }

            label1.Text = W.ToString();

        }

        private void DoStuff()
        {
            int total = 0;
            for (int i = 0; i < 100; i++)
            {
                total = i * 2;
                MessageBox.Show(total.ToString());

                for (int j = 0; j < 100; j++)
                {
                    int C = j * 2;
                    total += C;
                    MessageBox.Show(i.ToString());
                }

                i++;
                //j++;
            }
            //i++;
            //j++;

        }
    }
}
