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

    public partial class NewAssignmentViewer : UserControl
    {
        public NewAssignmentViewer()
        {
            InitializeComponent();
        }

        public void SetAssignmentInfoUI(Assignment assignment)
        {
            Enddate.Text = assignment.EndDate;
            Startdate.Text = assignment.StartDate;
            Noteslabel.Text = assignment.Notes;
            checkBox1.Checked = assignment.Paused;
        }
    }
}
