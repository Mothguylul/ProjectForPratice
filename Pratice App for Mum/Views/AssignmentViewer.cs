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

    public partial class AssignmentViewer : UserControl
    {
        private Form1 form1;

        public AssignmentViewer()
        {
            InitializeComponent();
            form1 = new Form1();
        }

        public void SetAssignmentInfoUI(Assignment assignment)
        {
            EnddateLabel.Text = assignment.EndDate;
            StartDateLabel.Text = assignment.StartDate;
            NotesAssignmentsLabel.Text = assignment.Notes;
            AssignmentPaused.Checked = assignment.Paused;
        }

        private void DeleteAssignmentbttn_Click(object sender, EventArgs e)
        {
            Worker? selectedWorker = form1.WorkerBox.SelectedItem as Worker;

            Assignment assignmentToDelete = (Assignment)DataAccess.Repository.GetWorkers().Where(assignment => assignment.Id == selectedWorker?.Id);

            if (assignmentToDelete != null)
            {
                DataAccess.Repository.DeleteAssignment(assignmentToDelete.Id);
                MessageBox.Show("Assignment deleted!");
            }
            else
            {
                MessageBox.Show("Failed to find Assignment");
            }
        }
    }
}
