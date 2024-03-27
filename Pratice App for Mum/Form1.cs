namespace Pratice_App_for_Mum;

using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
using System.Web;
using System.Windows.Forms;
using System.Linq;

public partial class Form1 : Form
{
    private IRepository repository;

    private Worker worker = new Worker();

    private Town town = new Town();

    public Form1()
    {
        InitializeComponent();

        repository = new Database();

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
        if (WorkersListBox.SelectedIndex != -1)
        {
            int selectedIndex = WorkersListBox.SelectedIndex;

            Worker? selectedWorker = WorkersListBox.Items[selectedIndex] as Worker;

            if (selectedWorker != null)
            {
                NameTextBox.Text = selectedWorker.Name;
                EmailTextBox.Text = selectedWorker.Email;
                MobilTextBox.Text = selectedWorker.Mobil.ToString();
                BirthDateTextBox.Text = selectedWorker.BirthDate;
            }
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
        if (TownComboBox.SelectedIndex != -1)
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
    }
}
