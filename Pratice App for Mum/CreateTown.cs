namespace Pratice_App_for_Mum
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SQLite;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class CreateTown : Form
    {
        private IRepository repository;

        public CreateTown()
        {
            InitializeComponent();

            repository = new Database();
        }

        private void CreateTown_Load(object sender, EventArgs e)
        {
        }

        private void CreateANewTown_Click(object sender, EventArgs e)
        {
            try
            {
                repository.CreateNewTown(userInputText.Text);
                Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
