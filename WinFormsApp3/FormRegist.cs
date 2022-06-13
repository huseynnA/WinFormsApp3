using LibForSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibForSql;
namespace WinFormsApp3
{
    public partial class FormRegist : Form
    {
        public FormRegist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseWorker dataBaseWorker = new DataBaseWorker();
            dataBaseWorker.InsertSQL(textBox1.Text,textBox2.Text,Convert.ToInt32(textBox3.Text),textBox4.Text);
        }
    }
}
