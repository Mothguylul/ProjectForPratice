// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

#pragma warning disable SA1600 // ElementsMustBeDocumented
#pragma warning disable SA1101 // PrefixLocalCallsWithThis

namespace Pratice_App_for_Mum
{
    using System;
    using System.Diagnostics;
    using System.Drawing.Text;
    using System.Reflection.Metadata.Ecma335;
    using System.Web;
    using System.Windows.Forms;

#pragma warning disable SA1601 // Partial elements should be documented
    public partial class Form1 : Form
#pragma warning restore SA1601 // Partial elements should be documented
    {
        private List<PersonalInfos> personalInfos;

        private List<EAinWork> eaInWork = new List<EAinWork>();

        private List<EAMissionPaused> eAMissionPaused = new List<EAMissionPaused>();

        // Help Variables
        private bool button5Clicked = false;

        public Form1()
        {
            InitializeComponent();

            Console1.Text = "startet";

            personalInfos = new List<PersonalInfos>();
            eaInWork = new List<EAinWork>();

            personalInfos.Add(new PersonalInfos { Name = "John", Mobil = 01737400374, Email = "johnson89@gmail.com", BirthDate = "05.09.1985 (30 jahre)", WorkersPlace = "Town1" });
            personalInfos.Add(new PersonalInfos { Name = "Peter ", Mobil = 7348939, Email = "peterparker89@gmail.com", BirthDate = "03.06.2000(24 Jahre)", WorkersPlace = "Town2" });
            personalInfos.Add(new PersonalInfos { Name = "Paul", Mobil = 02434374, Email = "paul89@gmail.com", BirthDate = "02.06.2010(14 Jahre)", WorkersPlace = "Town3" });
            personalInfos.Add(new PersonalInfos { Name = "Max", Mobil = 01737400374, Email = "max89@gmail.com", BirthDate = "05.09.1985 (30 jahre)", WorkersPlace = "Towm1" });
            personalInfos.Add(new PersonalInfos { Name = "Paul", Mobil = 01737400374, Email = "paul89@gmail.com", BirthDate = "05.09.1985 (30 jahre)", WorkersPlace = "Town2" });
            personalInfos.Add(new PersonalInfos { Name = "Ina", Mobil = 01737400374, Email = "ina89@gmail.com", BirthDate = "05.09.1985 (30 jahre)", WorkersPlace = "Town3" });

            foreach (PersonalInfos infosInCombobox in personalInfos)
            {
                comboBox1.Items.Add(infosInCombobox.Name);
            }

            foreach (PersonalInfos workersPlaceInfos in personalInfos)
            {
                comboBox5.Items.Add(workersPlaceInfos.WorkersPlace);
            }

            richTextBox15.Visible = false;
            richTextBox19.Visible = false;
            richTextBox20.Visible = false;
            richTextBox21.Visible = false;

            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
        }

        // EA Ready
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCustomer = (string)comboBox1.SelectedItem;

            PersonalInfos? findInfosOfSelectedEA = personalInfos.Find(pInfo => pInfo.Name == selectedCustomer);

            if (findInfosOfSelectedEA != null)
            {
                richTextBox5.Text = findInfosOfSelectedEA.Name;
                richTextBox6.Text = findInfosOfSelectedEA.Email;
                richTextBox7.Text = findInfosOfSelectedEA.Mobil.ToString();
                richTextBox1.Text = findInfosOfSelectedEA.BirthDate;
            }
        }

        // Safe Information Button
        private void Button2_Click(object sender, EventArgs e)
        {
            int selectedEA = comboBox1.SelectedIndex;

            string selectedEAname = (string)comboBox1.SelectedItem;

            if (selectedEA != -1)
            {
                string finalEA = (string)comboBox1.Items[selectedEA];

                comboBox2.Items.Add(finalEA);

                PersonalInfos? otherInfos = personalInfos.Find(pInfo => pInfo.Name == selectedEAname);

                if (otherInfos == null)
                {
                    return;
                }

                eaInWork.Add(new EAinWork { NameOfEA = otherInfos.Name, StartDate = richTextBox2.Text, EndDate = richTextBox8.Text, NameOfClient = (string)comboBox3.SelectedItem, BirthdateInWork = otherInfos.BirthDate, EmailInWork = otherInfos.Email, MobilInWork = otherInfos.Mobil, WorkNotes = richTextBox16.Text });

                personalInfos.Remove(otherInfos);
                comboBox1.Items.Remove(otherInfos.Name);

                richTextBox2.Clear();
                richTextBox8.Clear();
                richTextBox1.Clear();
                richTextBox7.Clear();
                richTextBox6.Clear();
                richTextBox5.Clear();
                richTextBox16.Clear();
                comboBox3.SelectedIndex = -1;
                comboBox1.Text = "Bitte ausfüllen";
            }
        }

        // Timeframe
        private void RichTextBox12_TextChanged(object sender, EventArgs e)
        {
        }

        // Pause Mission Button
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                Console1.Text = "Button1 clicked";

                string selectedEA = (string)comboBox2.SelectedItem;

                EAinWork? eAinWorkToRemove = eaInWork.Find(e => e.NameOfEA == selectedEA);

                if (eAinWorkToRemove != null)
                {
                    eAMissionPaused.Add(new EAMissionPaused { NameOfMissionPausedEA = eAinWorkToRemove.NameOfEA, NameOfPausedClient = eAinWorkToRemove.NameOfClient, PausedStartDate = eAinWorkToRemove.StartDate, PausedEndDate = eAinWorkToRemove.EndDate, PausedNotes = eAinWorkToRemove.WorkNotes, PausedBirthDate = eAinWorkToRemove.BirthdateInWork, PausedEmail = eAinWorkToRemove.EmailInWork, PausedMobil = eAinWorkToRemove.MobilInWork });

                    eaInWork.Remove(eAinWorkToRemove);

                    comboBox4.Items.Add(eAinWorkToRemove.NameOfEA);
                    comboBox2.Items.Remove(eAinWorkToRemove.NameOfEA);
                    richTextBox10.Clear();
                    richTextBox11.Clear();
                    richTextBox12.Clear();
                    richTextBox17.Clear();
                    comboBox2.Text = "Nichts ausgewählt"; // "not selected"
                }
            }
        }

        // EA already in work combobox
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EAinWork? eAinWork = eaInWork.Find(e => e.NameOfEA == comboBox2.SelectedItem.ToString());

            if (comboBox2.SelectedIndex != -1)
            {
                Debug.WriteLine("Hello");
                richTextBox10.Clear();
                richTextBox12.Clear();
                richTextBox11.Clear();

                if (eAinWork != null)
                {
                    richTextBox10.Text = eAinWork.NameOfEA;
                    richTextBox11.Text = eAinWork.NameOfClient;
                    richTextBox12.Text = eAinWork.StartDate + "    -    " + eAinWork.EndDate;
                    richTextBox17.Text = eAinWork.WorkNotes;
                }
            }
        }

        // Continue Mission Button
        private void Button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                Console1.Text = "Button4 clicked";

                string selectedEA = (string)comboBox4.SelectedItem;

                EAMissionPaused? searchEAMissionPaused = eAMissionPaused.Find(em => em.NameOfMissionPausedEA == selectedEA);

                if (searchEAMissionPaused != null)
                {
                    eaInWork.Add(new EAinWork { NameOfEA = searchEAMissionPaused.NameOfMissionPausedEA, NameOfClient = searchEAMissionPaused.NameOfPausedClient, EndDate = searchEAMissionPaused.PausedEndDate, StartDate = searchEAMissionPaused.PausedStartDate, WorkNotes = searchEAMissionPaused.PausedNotes, EmailInWork = searchEAMissionPaused.PausedEmail, MobilInWork = searchEAMissionPaused.PausedMobil, BirthdateInWork = searchEAMissionPaused.PausedBirthDate });

                    comboBox2.Items.Add(searchEAMissionPaused.NameOfMissionPausedEA);
                    comboBox4.Items.Remove(searchEAMissionPaused.NameOfMissionPausedEA);
                    richTextBox13.Clear();
                    richTextBox14.Clear();
                    richTextBox17.Clear();
                    richTextBox18.Clear();
                    comboBox4.Text = "Nicht ausgewählt"; // "not selected"

                    eAMissionPaused.Remove(searchEAMissionPaused);
                }
            }
        }

        // End Mission completly Button
        private void Button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                string selectedEA = (string)comboBox2.SelectedItem;

                EAinWork? searchEAMissionPaused = eaInWork.Find(em => em.NameOfEA == selectedEA);

                if (searchEAMissionPaused != null)
                {
                    personalInfos.Add(new PersonalInfos { Name = searchEAMissionPaused.NameOfEA, Email = searchEAMissionPaused.EmailInWork, BirthDate = searchEAMissionPaused.BirthdateInWork, Mobil = searchEAMissionPaused.MobilInWork, Notes = searchEAMissionPaused.WorkNotes });

                    comboBox1.Items.Add(searchEAMissionPaused.NameOfEA);
                    comboBox2.Items.Remove(searchEAMissionPaused.NameOfEA);
                    richTextBox10.Clear();
                    richTextBox11.Clear();
                    richTextBox12.Clear();
                    richTextBox17.Clear();

                    comboBox2.Text = "Nicht ausgewählt";
                    eaInWork.Remove(searchEAMissionPaused);
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (!button5Clicked)
            {
                string selectedPausedM = (string)comboBox2.SelectedItem;

                EAinWork? searchEAMissionPaused = eaInWork.Find(em => em.NameOfEA == selectedPausedM);

                richTextBox15.Visible = true;
                richTextBox19.Visible = true;
                richTextBox20.Visible = true;
                richTextBox21.Visible = true;

                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;

                if (searchEAMissionPaused != null)
                {
                    if (comboBox2.SelectedIndex != -1)
                    {
                        richTextBox19.Text = searchEAMissionPaused.EmailInWork;
                        richTextBox20.Text = searchEAMissionPaused.MobilInWork.ToString();
                        richTextBox21.Text = searchEAMissionPaused.BirthdateInWork;
                    }
                    else
                    {
                        Console1.Text = "Missing Index";
                    }
                }

                button5Clicked = true;
            }
            else
            {
                SetInfoElementsFalse();
                button5Clicked = false;
            }
        }

        private void SetInfoElementsFalse()
        {
            richTextBox15.Visible = false;
            richTextBox19.Visible = false;
            richTextBox20.Visible = false;
            richTextBox21.Visible = false;

            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // EA paused combobox
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EAMissionPaused? findName = eAMissionPaused.Find(em => em.NameOfMissionPausedEA == comboBox4.SelectedItem.ToString());

            if (findName == null)
            {
                return;
            }

            if (comboBox4.SelectedIndex != -1)
            {
                richTextBox13.Text = findName.NameOfMissionPausedEA;
                richTextBox14.Text = findName.NameOfPausedClient;
                richTextBox18.Text = findName.PausedNotes;
            }
        }

        // Client Name
        private void RichTextBox11_TextChanged(object sender, EventArgs e)
        {
        }

        // EA Name
        private void RichTextBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}