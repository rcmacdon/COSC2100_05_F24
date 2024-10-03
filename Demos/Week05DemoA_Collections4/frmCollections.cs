using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week05DemoA_Collections4.Properties;



namespace Week05DemoA_Collections4
{
    public partial class frmCollections : Form
    {

        private String[] studentsOLd = { "John", "Raj", "Harmondeep", "Sally", "Wai", "Jennifer", "George" };
        private String[] friendsOld = new String[7];


        private int[,] scores = new int[5, 19];
        //private String[,] tictactoe = { {,,} , {,, } , {,,} };

        private List<String> students = new List<String>();
        private List<String> friends = new List<String>();
        public frmCollections()
        {
            InitializeComponent();
        }

        private void frmCollections_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("The Author is " + Resources.AUTHOR);

            students.Clear();
            students.Add("John");
            students.Add("Raj");
            students.Add("Harmondeep");
            students.Add("Sally");
            students.Add("Wai");
            students.Add("Jennifer");
            students.Add("George");
            //students.AddRange()

            students.Sort();

            UpdateLists();
            
        }

        private void UpdateLists()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;

            listBox1.DataSource = students;
            listBox2.DataSource = friends;

            label1.Text = students.Count.ToString();
            label2.Text = friends.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                String str = listBox1.SelectedItem.ToString();

                MessageBox.Show("The Name " + str + " is found at " + students.IndexOf(str));
                friends.Add(str);
                students.Remove(str);

                UpdateLists();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0) 
            {
                students.Add(listBox2.SelectedItem.ToString());
                friends.Remove(listBox2.SelectedItem.ToString());

                UpdateLists();
            }
        }
    }
}
