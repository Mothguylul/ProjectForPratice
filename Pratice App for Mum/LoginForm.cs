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
        private string password = "hello";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == password)
            {
                Form1 form1 = new Form1();

                Close();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }
    }
}
