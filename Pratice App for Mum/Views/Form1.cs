namespace Pratice_App_for_Mum;

using System;
using System.Windows.Forms;
using System.Linq;
using Pratice_App_for_Mum.Database;
using Pratice_App_for_Mum.Models;
using Pratice_App_for_Mum.Views;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        RefreshTowns(this, EventArgs.Empty);
    }

    public ListBox WorkerBox => WorkersListBox;

    private void WorkersListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        RefreshWorkerInfo();
        RefreshAssignmentInfo(sender, e);
    }

    private void RefreshTowns(object? sender, EventArgs e)
    {
        TownComboBox.Items.Clear();

        foreach (Town town in DataAccess.Repository.GetTowns())
        {
            TownComboBox.Items.Add(town);
        }
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

        DataAccess.Repository.DeleteTown(selectedTown.Id);
        TownComboBox.Items.Remove(selectedTown);
    }

    private void TownComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        WorkersListBox.SelectedIndex = -1; // this will refresh the workers/assignment info
        WorkersListBox.Items.Clear();

        Town? selectedTown = TownComboBox.SelectedItem as Town;

        if (selectedTown is not null)
        {
            foreach (Worker worker in DataAccess.Repository.GetWorkers().Where(w => w.TownId == selectedTown.Id))
            {
                WorkersListBox.Items.Add(worker);
            }
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

    private void RefreshAssignmentInfo(object? sender, EventArgs e)
    {
        Worker? selectedWorker = WorkersListBox.SelectedItem as Worker;

        if (selectedWorker is null)
        {
            return;
        }

        Assignment? currentAssignment = DataAccess.Repository.GetAssignments().FirstOrDefault(a => a.WorkerId == selectedWorker.Id);

        if (currentAssignment is not null)
        {
            assignmentViewerUI.SetAssignmentInfoUI(currentAssignment);
            assignmentViewerUI.Visible = true;
            Createbttn.Visible = false;
        }
        else
        {
            assignmentViewerUI.Visible = false;
            Createbttn.Visible = true;
        }
    }

    private void Createbttn_Click(object sender, EventArgs e)
    {
        CreateAssignment createAssignment = new CreateAssignment((Worker)WorkersListBox.SelectedItem);
        createAssignment.FormClosed += RefreshAssignmentInfo;
        createAssignment.Show();
    }

    private void CalenderCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        Calender.Visible = CalenderCheckBox.Checked ? true : false;
    }
}