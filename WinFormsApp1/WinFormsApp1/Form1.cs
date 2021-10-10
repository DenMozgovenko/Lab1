using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = false;
            string[,] login_pass = { { "Andy", "Panda" } , {"Valentine","Ch1nCh0pa"} , {"Sasha","ShaurmaLove1"} , {"Den","KiborgUbica"} , {"Vova","Mitozheumeembegat"} };
            for (int i = 0; i < 5; i++)
            {
                if (textBox1.Text == login_pass[i, 0] && textBox2.Text == login_pass[i, 1])
                { a = true; if (a == true) { MessageBox.Show("Welcome to system!");break; }}
            }
                if (a == false){MessageBox.Show("Error, incorect login or password!"); }
        }
    }
}
