using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Register")
            {
                this.Hide();
                FormRegist formRegist = new FormRegist();
                formRegist.Show();
            }
            else if (comboBox1.Text == "Login")
            {
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
            else 
            {
                MessageBox.Show("Please select ");
            }
        }
    }
}
