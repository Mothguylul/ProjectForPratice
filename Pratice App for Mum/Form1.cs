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

            var filteredWorkers = repository.GetWorkers().Where(worker => worker.TownId == selectedTown.TownID);

            foreach (var worker in filteredWorkers)
            {
                WorkersListBox.Items.Add(worker);
            }
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
}
