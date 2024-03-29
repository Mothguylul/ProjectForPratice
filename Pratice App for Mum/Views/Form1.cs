namespace Pratice_App_for_Mum;

using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
using System.Web;
using System.Windows.Forms;
using System.Linq;
using Pratice_App_for_Mum.Database;
using Pratice_App_for_Mum.Models;
using System.Drawing.Design;

public partial class Form1 : Form
{
    private IRepository repository;

    private Worker worker = new Worker();

    private Town town = new Town();

    public Form1()
    {
        InitializeComponent();

        repository = new Repository();

        foreach (Town town in repository.GetTowns())
        {
            TownComboBox.Items.Add(town);
        }
    }

    private void TownComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        WorkersListBox.Items.Clear();

        if (TownComboBox.SelectedIndex != -1)
        {
            Town selectedTown = (Town)TownComboBox.SelectedItem;

            var filteredWorkers = repository.GetWorkers().Where(worker => worker.TownId == selectedTown.Id);

            foreach (var worker in filteredWorkers)
            {
                WorkersListBox.Items.Add(worker);
            }
        }
    }

    private void RefreshTowns(object? sender, EventArgs e)
    {
        TownComboBox.Items.Clear();

        foreach (Town town in repository.GetTowns())
        {
            TownComboBox.Items.Add(town);
        }
    }

    private void WorkersListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        RefreshAssignmentInfo();
        RefreshWorkerInfo();
    }

    private void CreateTownButton_Click(object sender, EventArgs e)
    {
        CreateTown createTown = new CreateTown();

        createTown.FormClosed += RefreshTowns;
        createTown.Show();
    }

    private void DeleteTownButton_Click(object sender, EventArgs e)
    {
        Town? selectedTown = TownComboBox.SelectedItem as Town;

        if (selectedTown is null)
        {
            MessageBox.Show("Select a town to delete first!");
            return;
        }

        repository.DeleteTown(selectedTown.Id);
        TownComboBox.Items.Remove(selectedTown);
    }

    private void RefreshAssignmentInfo()
    {
        Worker? selectedWorker = WorkersListBox.SelectedItem as Worker;

        if (selectedWorker is null)
        {
            return;
        }

        Assignment? currentAssignment = repository.GetAssignments().FirstOrDefault(a => a.WorkerId == selectedWorker.Id);

        NameOfAssignmentWorkertxt.Text = selectedWorker.Name;

        if (currentAssignment is not null)
        {
            StartDatetxt.Text = currentAssignment.StartDate;
            EndDatetxt.Text = currentAssignment.EndDate;
            StartAssignmentbttn.Visible = false;
            AssignmentClientcombox.Visible = false;
            NameOfClienttxt.Visible = true;    // The client name will be in this textbox
            EndTaskbttn.Visible = true;
            Pauseassignmentbttn.Visible = true;
            AssignmentInfoLbl.Text = "Assignment running";
        }
        else
        {
            EndTaskbttn.Visible = false;
            Pauseassignmentbttn.Visible = false;
            StartAssignmentbttn.Visible = true;
            AssignmentInfoLbl.Text = "No Assignment";
        }
    }

    private void RefreshWorkerInfo()
    {
        Worker? selectedWorker = WorkersListBox.SelectedItem as Worker;

        NameTextBox.Text = selectedWorker is null ? string.Empty : selectedWorker.Name;
        EmailTextBox.Text = selectedWorker is null ? string.Empty : selectedWorker.Email;
        MobilTextBox.Text = selectedWorker is null ? string.Empty : selectedWorker.Mobil.ToString();
        BirthDateTextBox.Text = selectedWorker is null ? string.Empty : selectedWorker.BirthDate;
    }

    private void NameTextBox_TextChanged(object sender, EventArgs e)
    {
    }
}
