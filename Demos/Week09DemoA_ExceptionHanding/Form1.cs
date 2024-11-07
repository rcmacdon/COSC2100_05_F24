using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week09DemoA_ExceptionHanding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxOperator.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double answer = 0;
            bool valid = true;

            switch (cbxOperator.SelectedItem.ToString()) {
               case "+":
                    answer = MyMath.Add((double)nud1.Value, (double)nud2.Value);
                    break;
                case "-":
                    answer = MyMath.Subtract((double)nud1.Value, (double)nud2.Value);
                    break;
                case "*":
                    answer = MyMath.Multiply((double)nud1.Value, (double)nud2.Value);
                    break;
                case "/":
                    try
                    {
                        answer = MyMath.Divide((double)nud1.Value, (double)nud2.Value);
                    }
                    catch (DivideByZeroException ex)
                    {
                        lblMessage.Text = ex.Message;
                        valid = false;
                    }
                    break;
                case "x^y":
                    answer = MyMath.Power((double)nud1.Value, (double)nud2.Value);
                    break;
                case "sqrt":
                    try
                    {
                        answer = MyMath.Sqrt((double)nud1.Value);
                    }
                    catch (ArithmeticException ex)
                    {
                        lblMessage.Text = ex.Message;
                        valid = false;
                    }
                    break;
            }
            if (valid) lblAnswer.Text = answer.ToString();
            else lblAnswer.Text = "error";
        }



        }
    }

