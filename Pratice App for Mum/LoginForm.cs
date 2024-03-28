namespace Pratice_App_for_Mum
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class LoginForm : Form
    {
        private string password = "_password123";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            if (PasswordTextBox.Text == password)
            {
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }
    }
}
