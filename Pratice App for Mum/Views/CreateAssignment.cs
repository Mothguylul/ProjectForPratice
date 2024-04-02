namespace Pratice_App_for_Mum.Views
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
    using Pratice_App_for_Mum.Database;
    using Pratice_App_for_Mum.Models;

    public partial class CreateAssignment : Form
    {
        private readonly Worker worker;

        public CreateAssignment(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;

            NameLabel.Text = worker.Name;
        }

        private void Startbttn_Click(object sender, EventArgs e)
        {
            Assignment assignment = new Assignment()
            {
                StartDate = Startdatetxt.Text,
                EndDate = Enddatetxt.Text,
                Notes = NotesRichtxt.Text,
                WorkerId = worker.Id,
            };

            DataAccess.Repository.CreateAssignment(assignment);

            Close();
        }
    }
}
