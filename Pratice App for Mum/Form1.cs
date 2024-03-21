using System.Diagnostics;
using System.Drawing.Text;
using System.Web;

namespace Pratice_App_for_Mum
{
    public partial class Form1 : Form
    {
        public class PersonalInfos
        {
            public string Name { get; set; }
            public int Mobil { get; set; }
            public string Email { get; set; }
            public string BirthDate { get; set; }
        }

        public class EAinWork
        {
            public string NameOfClient { get; set; }
            public string NameOfEA { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public string EmailInWork { get; set; }
            public int MobilInWork { get; set; }
            public string BirthdateInWork { get; set; }

        }

        public class EAMissionPaused
        {
            public string NameOfMissionPausedEA { get; set; }
            public string NameOfPausedClient { get; set; }
            public string PausedEndDate { get; set; }
            public string PausedStartDate { get; set; }
        }


        private List<PersonalInfos> personalInfos;

        private List<EAinWork> eaInWork = new List<EAinWork>();

        private List<EAMissionPaused> eAMissionPaused = new List<EAMissionPaused>();

        //Btw, EA just means "Ehren Amtlicher" translates to "volunteer" I think, so just a worker

        public Form1()
        {
            InitializeComponent();

            personalInfos = new List<PersonalInfos>();
            eaInWork = new List<EAinWork>();

            personalInfos.Add(new PersonalInfos { Name = "John Johnson ", Mobil = 01737400374, Email = "johnson89@gmail.com", BirthDate = "05.09.1985 (30 jahre)" });
            personalInfos.Add(new PersonalInfos { Name = "Peter ", Mobil = 7348939, Email = "peterparker89@gmail.com", BirthDate = "03.06.2000" });
            personalInfos.Add(new PersonalInfos { Name = "Monke123", Mobil = 02434374, Email = "monke89@gmail.com", BirthDate = "02.06.2010" });



            foreach (PersonalInfos infosInCombobox in personalInfos)
            {
                comboBox1.Items.Add(infosInCombobox.Name);
            }
        }

        //EA Ready
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedCustomer = comboBox1.SelectedItem.ToString();

            PersonalInfos findInfosOfSelectedEA = personalInfos.Find(pInfo => pInfo.Name == selectedCustomer);

            if (findInfosOfSelectedEA != null)
            {
                richTextBox5.Text = findInfosOfSelectedEA.Name;
                richTextBox6.Text = findInfosOfSelectedEA.Email;
                richTextBox7.Text = findInfosOfSelectedEA.Mobil.ToString();
                richTextBox1.Text = findInfosOfSelectedEA.BirthDate;
            }

        }


        //Safe Information Button
        private void button2_Click(object sender, EventArgs e)
        {

            int selectedEA = comboBox1.SelectedIndex;

            string selectedEAname = comboBox1.SelectedItem.ToString();

            if (selectedEA != -1)
            {

                string finalEA = comboBox1.Items[selectedEA].ToString();

                comboBox2.Items.Add(finalEA);

                PersonalInfos otherInfos = personalInfos.Find(pInfo => pInfo.Name == selectedEAname);

                eaInWork.Add(new EAinWork { NameOfEA = otherInfos.Name, StartDate = richTextBox2.Text, EndDate = richTextBox8.Text, NameOfClient = comboBox3.SelectedItem.ToString(), BirthdateInWork = otherInfos.BirthDate, EmailInWork = otherInfos.Email, MobilInWork = otherInfos.Mobil });

                personalInfos.Remove(otherInfos);
                comboBox1.Items.Remove(otherInfos.Name);

                richTextBox2.Clear();
                richTextBox8.Clear();
                richTextBox1.Clear();
                richTextBox7.Clear();
                richTextBox6.Clear();
                richTextBox5.Clear();
                comboBox3.SelectedIndex = -1;
                comboBox1.Text = "Bitte ausfüllen";

            }

        }



        //Timeframe 
        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        //Pause Mission Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                Console1.Text = "Button1 clicked";

                string selectedEA = comboBox2.SelectedItem.ToString();

                EAinWork eAinWorkToRemove = eaInWork.Find(e => e.NameOfEA == selectedEA);



                if (eAinWorkToRemove != null)
                {
                    eAMissionPaused.Add(new EAMissionPaused { NameOfMissionPausedEA = eAinWorkToRemove.NameOfEA, NameOfPausedClient = eAinWorkToRemove.NameOfClient, PausedStartDate = eAinWorkToRemove.StartDate, PausedEndDate = eAinWorkToRemove.EndDate });

                    eaInWork.Remove(eAinWorkToRemove);

                    comboBox4.Items.Add(eAinWorkToRemove.NameOfEA);
                    comboBox2.Items.Remove(eAinWorkToRemove.NameOfEA);
                    richTextBox10.Clear();
                    richTextBox11.Clear();
                    richTextBox12.Clear();
                    comboBox2.Text = "Nichts ausgewählt"; //"not selected"
                }
            }
        }

        //EA already in work combobox
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            EAinWork eAinWork = eaInWork.Find(e => e.NameOfEA == comboBox2.SelectedItem.ToString());

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

                }
            }
        }
       

        //Continue Mission Button
        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                Console1.Text = "Button4 clicked";

                string selectedEA = comboBox4.SelectedItem.ToString();

                EAMissionPaused searchEAMissionPaused = eAMissionPaused.Find(em => em.NameOfMissionPausedEA == selectedEA);

                if (searchEAMissionPaused != null)
                {
                    eaInWork.Add(new EAinWork { NameOfEA = searchEAMissionPaused.NameOfMissionPausedEA, NameOfClient = searchEAMissionPaused.NameOfPausedClient, EndDate = searchEAMissionPaused.PausedEndDate, StartDate = searchEAMissionPaused.PausedStartDate });

                    comboBox2.Items.Add(searchEAMissionPaused.NameOfMissionPausedEA);
                    comboBox4.Items.Remove(searchEAMissionPaused.NameOfMissionPausedEA);
                    richTextBox13.Clear();
                    richTextBox14.Clear();
                    comboBox4.Text = "Nicht ausgewählt"; //"not selected"

                    eAMissionPaused.Remove(searchEAMissionPaused);
                }
            }
        }

        //End Mission completly Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                string selectedEA = comboBox2.SelectedItem.ToString();

                EAinWork searchEAMissionPaused = eaInWork.Find(em => em.NameOfEA == selectedEA);

                if (searchEAMissionPaused != null)
                {
                    personalInfos.Add(new PersonalInfos { Name = searchEAMissionPaused.NameOfEA, Email = searchEAMissionPaused.EmailInWork, BirthDate = searchEAMissionPaused.BirthdateInWork, Mobil = searchEAMissionPaused.MobilInWork });

                    comboBox1.Items.Add(searchEAMissionPaused.NameOfEA);
                    comboBox2.Items.Remove(searchEAMissionPaused.NameOfEA);
                    richTextBox10.Clear();
                    richTextBox11.Clear();
                    richTextBox12.Clear();

                    comboBox2.Text = "Nicht ausgewählt";
                    eaInWork.Remove(searchEAMissionPaused);
                }
            }
        }

        //EA paused combobox
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EAMissionPaused findName = eAMissionPaused.Find(em => em.NameOfMissionPausedEA == comboBox4.SelectedItem.ToString());

            if (comboBox4.SelectedIndex != -1)
            {
                richTextBox13.Text = findName.NameOfMissionPausedEA;
                richTextBox14.Text = findName.NameOfPausedClient;
            }
        }

        //Client Name 
        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        //EA Name 
        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }


        //Name of client combobox
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //End Date richtextbox
        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }
        //Start Date richtextbox
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //PersonalInfos, Workers name richtextbox
        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //personalInfos, Email richtextbox
        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        //PersonalInfos, Mobil richtextbox
        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }
        //Name of paused Ea richtextbox
        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        //Name of Paused Client richtextbox
        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        //PersonalInfos, Birthdate richtextbox
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }


        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}