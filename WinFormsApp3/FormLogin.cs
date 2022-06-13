using LibForUser;
using System;
using System.Windows.Forms;

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
            classforUser classforUser = new classforUser();
            if (classforUser.Eque(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Log in successfull");
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Has error ocurred .Please try again");
            }

        }
    }
}
