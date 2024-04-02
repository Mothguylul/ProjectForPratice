namespace Pratice_App_for_Mum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label25 = new Label();
            TownComboBox = new ComboBox();
            WorkersListBox = new ListBox();
            label1 = new Label();
            NameTextBox = new TextBox();
            label2 = new Label();
            EmailTextBox = new TextBox();
            label3 = new Label();
            BirthDateTextBox = new TextBox();
            label4 = new Label();
            MobilTextBox = new TextBox();
            CreateTownNutton = new Button();
            DeleteTownButton = new Button();
            groupBox1 = new GroupBox();
            WorkerNotestxt = new RichTextBox();
            label5 = new Label();
            Calender = new MonthCalendar();
            CalenderCheckBox = new CheckBox();
            groupBox2 = new GroupBox();
            Createbttn = new Button();
            assignmentViewer1 = new Views.AssignmentViewer();
            assignmentViewer2 = new Views.AssignmentViewer();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(59, 81);
            label25.Name = "label25";
            label25.Size = new Size(0, 30);
            label25.TabIndex = 70;
            // 
            // TownComboBox
            // 
            TownComboBox.DisplayMember = "Name";
            TownComboBox.FormattingEnabled = true;
            TownComboBox.Location = new Point(258, 111);
            TownComboBox.Name = "TownComboBox";
            TownComboBox.Size = new Size(157, 38);
            TownComboBox.TabIndex = 71;
            TownComboBox.SelectedIndexChanged += TownComboBox_SelectedIndexChanged;
            // 
            // WorkersListBox
            // 
            WorkersListBox.DisplayMember = "Name";
            WorkersListBox.FormattingEnabled = true;
            WorkersListBox.ItemHeight = 30;
            WorkersListBox.Location = new Point(258, 152);
            WorkersListBox.Name = "WorkersListBox";
            WorkersListBox.Size = new Size(157, 574);
            WorkersListBox.TabIndex = 72;
            WorkersListBox.SelectedIndexChanged += WorkersListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 53);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 74;
            label1.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(92, 44);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(309, 33);
            NameTextBox.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 97);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 76;
            label2.Text = "Email:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.Location = new Point(92, 91);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(309, 33);
            EmailTextBox.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 193);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 78;
            label3.Text = "Birthdate:";
            // 
            // BirthDateTextBox
            // 
            BirthDateTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BirthDateTextBox.Location = new Point(92, 187);
            BirthDateTextBox.Name = "BirthDateTextBox";
            BirthDateTextBox.Size = new Size(309, 33);
            BirthDateTextBox.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 145);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 80;
            label4.Text = "Mobil:";
            // 
            // MobilTextBox
            // 
            MobilTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MobilTextBox.Location = new Point(92, 139);
            MobilTextBox.Name = "MobilTextBox";
            MobilTextBox.Size = new Size(309, 33);
            MobilTextBox.TabIndex = 81;
            // 
            // CreateTownNutton
            // 
            CreateTownNutton.BackColor = SystemColors.ControlDark;
            CreateTownNutton.Location = new Point(40, 108);
            CreateTownNutton.Name = "CreateTownNutton";
            CreateTownNutton.Size = new Size(103, 41);
            CreateTownNutton.TabIndex = 82;
            CreateTownNutton.Text = "Create";
            CreateTownNutton.UseVisualStyleBackColor = false;
            CreateTownNutton.Click += CreateTownButton_Click;
            // 
            // DeleteTownButton
            // 
            DeleteTownButton.BackColor = SystemColors.ControlDark;
            DeleteTownButton.Location = new Point(149, 111);
            DeleteTownButton.Name = "DeleteTownButton";
            DeleteTownButton.Size = new Size(103, 41);
            DeleteTownButton.TabIndex = 83;
            DeleteTownButton.Text = "Delete";
            DeleteTownButton.UseVisualStyleBackColor = false;
            DeleteTownButton.Click += DeleteTownButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WorkerNotestxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(EmailTextBox);
            groupBox1.Controls.Add(MobilTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(BirthDateTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(432, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 345);
            groupBox1.TabIndex = 84;
            groupBox1.TabStop = false;
            groupBox1.Text = "Worker Info";
            // 
            // WorkerNotestxt
            // 
            WorkerNotestxt.Location = new Point(92, 237);
            WorkerNotestxt.Name = "WorkerNotestxt";
            WorkerNotestxt.Size = new Size(309, 85);
            WorkerNotestxt.TabIndex = 84;
            WorkerNotestxt.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 237);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 82;
            label5.Text = "Notes:";
            // 
            // Calender
            // 
            Calender.Location = new Point(981, 143);
            Calender.Name = "Calender";
            Calender.TabIndex = 98;
            Calender.Visible = false;
            // 
            // CalenderCheckBox
            // 
            CalenderCheckBox.AutoSize = true;
            CalenderCheckBox.Location = new Point(874, 108);
            CalenderCheckBox.Name = "CalenderCheckBox";
            CalenderCheckBox.Size = new Size(114, 34);
            CalenderCheckBox.TabIndex = 99;
            CalenderCheckBox.Text = "Calender";
            CalenderCheckBox.UseVisualStyleBackColor = true;
            CalenderCheckBox.CheckedChanged += CalenderCheckBox_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(assignmentViewer2);
            groupBox2.Controls.Add(Createbttn);
            groupBox2.Controls.Add(assignmentViewer1);
            groupBox2.Location = new Point(432, 471);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 288);
            groupBox2.TabIndex = 100;
            groupBox2.TabStop = false;
            groupBox2.Text = "Assignment";
            // 
            // Createbttn
            // 
            Createbttn.Location = new Point(308, 233);
            Createbttn.Name = "Createbttn";
            Createbttn.Size = new Size(93, 37);
            Createbttn.TabIndex = 2;
            Createbttn.Text = "Create";
            Createbttn.UseVisualStyleBackColor = true;
            Createbttn.Click += Createbttn_Click;
            // 
            // assignmentViewer1
            // 
            assignmentViewer1.Location = new Point(-641, -164);
            assignmentViewer1.Margin = new Padding(5, 6, 5, 4);
            assignmentViewer1.Name = "assignmentViewer1";
            assignmentViewer1.Size = new Size(99, 618);
            assignmentViewer1.TabIndex = 0;
            // 
            // assignmentViewer2
            // 
            assignmentViewer2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            assignmentViewer2.Location = new Point(13, 28);
            assignmentViewer2.Margin = new Padding(0);
            assignmentViewer2.Name = "assignmentViewer2";
            assignmentViewer2.Size = new Size(411, 257);
            assignmentViewer2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 961);
            Controls.Add(groupBox2);
            Controls.Add(CalenderCheckBox);
            Controls.Add(Calender);
            Controls.Add(groupBox1);
            Controls.Add(DeleteTownButton);
            Controls.Add(CreateTownNutton);
            Controls.Add(WorkersListBox);
            Controls.Add(TownComboBox);
            Controls.Add(label25);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label25;
        private ComboBox TownComboBox;
        private ListBox WorkersListBox;
        private Label label1;
        private TextBox NameTextBox;
        private Label label2;
        private TextBox EmailTextBox;
        private Label label3;
        private TextBox BirthDateTextBox;
        private Label label4;
        private TextBox MobilTextBox;
        private Button CreateTownNutton;
        private Button DeleteTownButton;
        private GroupBox groupBox1;
        private RichTextBox WorkerNotestxt;
        private Label label5;
        private MonthCalendar Calender;
        private CheckBox CalenderCheckBox;
        private GroupBox groupBox2;
        private Views.AssignmentViewer assignmentViewer1;
        private Button Createbttn;
        private Views.AssignmentViewer assignmentViewer2;
    }
}