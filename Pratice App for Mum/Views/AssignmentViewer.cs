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
        private Assignment? currentAssignment;

        public AssignmentViewer()
        {
            InitializeComponent();
        }

        public event EventHandler? DeleteButtonClicked;

        public void SetAssignmentInfoUI(Assignment assignment)
        {
            EnddateLabel.Text = assignment.EndDate;
            StartDateLabel.Text = assignment.StartDate;
            NotesAssignmentsLabel.Text = assignment.Notes;
            AssignmentPaused.Checked = assignment.Paused;

            currentAssignment = assignment;
        }

        private void DeleteAssignmentbttn_Click(object sender, EventArgs e)
        {
            if (currentAssignment != null)
            {
                DataAccess.Repository.DeleteAssignment(currentAssignment.Id);
                DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void AssignmentPaused_CheckedChanged(object sender, EventArgs e)
        {
            if (currentAssignment is not null)
            {
                DataAccess.Repository.TogglePause(currentAssignment);
            }
        }
    }
}
