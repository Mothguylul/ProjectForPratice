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
        ResetAssignmentUI();
        ResetWorkerInfoUI();

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

        if (currentAssignment is not null)
        {
            EndDateLabel.Visible = true;
            StartDateLabel.Visible = true;
            NameLabel.Visible = true;

            NameOfAssignmentWorkertxt.Visible = false;
            StartDatetxt.Visible = false;
            EndDatetxt.Visible = false;
            StartDateLabel.Text = currentAssignment.StartDate;
            EndDateLabel.Text = currentAssignment.EndDate;
            NameLabel.Text = selectedWorker.Name;
            StartAssignmentbttn.Visible = false;
            AssignmentClientcombox.Visible = false;
            NameOfClienttxt.Visible = true;
            EndTaskbttn.Visible = true;
            Pauseassignmentbttn.Visible = true;
            AssignmentInfoLbl.Text = "Assignment running";
        }
        else
        {
            EndDateLabel.Visible = false;
            StartDateLabel.Visible = false;
            NameLabel.Visible = false;

            NameOfAssignmentWorkertxt.Visible = true;
            StartDatetxt.Visible = true;
            EndDatetxt.Visible = true;

            NameOfAssignmentWorkertxt.Text = selectedWorker.Name;
            EndTaskbttn.Visible = false;
            Pauseassignmentbttn.Visible = false;
            StartAssignmentbttn.Visible = true;
            AssignmentInfoLbl.Text = "No Assignment";
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

    private void RefreshWorkerInfo()
    {
        Worker? selectedWorker = WorkersListBox.SelectedItem as Worker;

        NameTextBox.Text = selectedWorker is null ? string.Empty : selectedWorker.Name;
        EmailTextBox.Text = selectedWorker is null ? string.Empty : selectedWorker.Email;
        MobilTextBox.Text = selectedWorker is null ? string.Empty : selectedWorker.Mobil.ToString();
        BirthDateTextBox.Text = selectedWorker is null ? string.Empty : selectedWorker.BirthDate;
    }

    // Reset UI
    private void ResetAssignmentUI()
    {
        NameOfAssignmentWorkertxt.Clear();
        StartDatetxt.Clear();
        EndDatetxt.Clear();

        NameOfAssignmentWorkertxt.Visible = true;
        StartDatetxt.Visible = true;
        EndDatetxt.Visible = true;

        NameLabel.Visible = false;
        StartDateLabel.Visible = false;
        EndDateLabel.Visible = false;
    }

    private void ResetWorkerInfoUI()
    {
        NameTextBox.Clear();
        EmailTextBox.Clear();
        MobilTextBox.Clear();
        BirthDateTextBox.Clear();
        WorkerNotestxt.Clear();
    }

    private void CalenderCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        Calender.Visible = CalenderCheckBox.Checked ? true : false;
    }
}
