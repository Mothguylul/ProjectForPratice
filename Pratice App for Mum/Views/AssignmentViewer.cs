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
    using Pratice_App_for_Mum.Models;

    public partial class AssignmentViewer : UserControl
    {
        public AssignmentViewer()
        {
            InitializeComponent();
        }

        public void SetAssignmentInfoUI(Assignment assignment)
        {
            EnddateLabel.Text = assignment.EndDate;
            StartDateLabel.Text = assignment.StartDate;
            NotesAssignmentsLabel.Text = assignment.Notes;
            AssignmentPaused.Checked = assignment.Paused;
        }
    }
}
