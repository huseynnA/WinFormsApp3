using LibForSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibForSql;

namespace WinFormsApp3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataBaseWorker dataBaseWorker = new DataBaseWorker();
            if (dataBaseWorker.Select(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Log in successfull");
            }
            else 
            {
                MessageBox.Show("Has error ocurred .Please try again");
            }

        }
    }
}
