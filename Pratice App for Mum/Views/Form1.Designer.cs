﻿namespace Pratice_App_for_Mum
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
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            AssignmentInfoLbl = new Label();
            Pauseassignmentbttn = new Button();
            NameOfClienttxt = new TextBox();
            EndTaskbttn = new Button();
            groupBox3 = new GroupBox();
            label9 = new Label();
            EndDatetxt = new TextBox();
            label8 = new Label();
            StartDatetxt = new TextBox();
            label7 = new Label();
            NameOfAssignmentWorkertxt = new TextBox();
            label6 = new Label();
            AssignmentClientcombox = new ComboBox();
            StartAssignmentbttn = new Button();
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
            NameTextBox.TextChanged += NameTextBox_TextChanged;
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
            groupBox1.Controls.Add(richTextBox1);
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(92, 237);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(309, 85);
            richTextBox1.TabIndex = 84;
            richTextBox1.Text = "";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(AssignmentInfoLbl);
            groupBox2.Controls.Add(Pauseassignmentbttn);
            groupBox2.Controls.Add(NameOfClienttxt);
            groupBox2.Controls.Add(EndTaskbttn);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(EndDatetxt);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(StartDatetxt);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(NameOfAssignmentWorkertxt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(AssignmentClientcombox);
            groupBox2.Controls.Add(StartAssignmentbttn);
            groupBox2.Location = new Point(432, 470);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 313);
            groupBox2.TabIndex = 85;
            groupBox2.TabStop = false;
            groupBox2.Text = "Assignments";
            // 
            // AssignmentInfoLbl
            // 
            AssignmentInfoLbl.AutoSize = true;
            AssignmentInfoLbl.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            AssignmentInfoLbl.Location = new Point(10, 31);
            AssignmentInfoLbl.Name = "AssignmentInfoLbl";
            AssignmentInfoLbl.Size = new Size(13, 21);
            AssignmentInfoLbl.TabIndex = 94;
            AssignmentInfoLbl.Text = ".";
            // 
            // Pauseassignmentbttn
            // 
            Pauseassignmentbttn.Location = new Point(10, 243);
            Pauseassignmentbttn.Name = "Pauseassignmentbttn";
            Pauseassignmentbttn.Size = new Size(202, 42);
            Pauseassignmentbttn.TabIndex = 93;
            Pauseassignmentbttn.Text = "Pause Assignment";
            Pauseassignmentbttn.UseVisualStyleBackColor = true;
            // 
            // NameOfClienttxt
            // 
            NameOfClienttxt.Location = new Point(297, 202);
            NameOfClienttxt.Name = "NameOfClienttxt";
            NameOfClienttxt.Size = new Size(121, 35);
            NameOfClienttxt.TabIndex = 92;
            // 
            // EndTaskbttn
            // 
            EndTaskbttn.Location = new Point(10, 195);
            EndTaskbttn.Name = "EndTaskbttn";
            EndTaskbttn.Size = new Size(202, 42);
            EndTaskbttn.TabIndex = 92;
            EndTaskbttn.Text = "End Assignment";
            EndTaskbttn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(424, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 86;
            groupBox3.TabStop = false;
            groupBox3.Text = "Infos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(297, 175);
            label9.Name = "label9";
            label9.Size = new Size(53, 21);
            label9.TabIndex = 91;
            label9.Text = "Client:";
            // 
            // EndDatetxt
            // 
            EndDatetxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EndDatetxt.Location = new Point(232, 124);
            EndDatetxt.Name = "EndDatetxt";
            EndDatetxt.Size = new Size(186, 33);
            EndDatetxt.TabIndex = 90;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(202, 121);
            label8.Name = "label8";
            label8.Size = new Size(24, 32);
            label8.TabIndex = 89;
            label8.Text = "-";
            // 
            // StartDatetxt
            // 
            StartDatetxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartDatetxt.Location = new Point(10, 124);
            StartDatetxt.Name = "StartDatetxt";
            StartDatetxt.Size = new Size(186, 33);
            StartDatetxt.TabIndex = 88;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(161, 91);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 87;
            label7.Text = "Task Timespan";
            // 
            // NameOfAssignmentWorkertxt
            // 
            NameOfAssignmentWorkertxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameOfAssignmentWorkertxt.Location = new Point(71, 55);
            NameOfAssignmentWorkertxt.Name = "NameOfAssignmentWorkertxt";
            NameOfAssignmentWorkertxt.Size = new Size(309, 33);
            NameOfAssignmentWorkertxt.TabIndex = 85;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 61);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 85;
            label6.Text = "Name:";
            // 
            // AssignmentClientcombox
            // 
            AssignmentClientcombox.FormattingEnabled = true;
            AssignmentClientcombox.Location = new Point(297, 199);
            AssignmentClientcombox.Name = "AssignmentClientcombox";
            AssignmentClientcombox.Size = new Size(121, 38);
            AssignmentClientcombox.TabIndex = 86;
            // 
            // StartAssignmentbttn
            // 
            StartAssignmentbttn.Location = new Point(10, 195);
            StartAssignmentbttn.Name = "StartAssignmentbttn";
            StartAssignmentbttn.Size = new Size(135, 42);
            StartAssignmentbttn.TabIndex = 0;
            StartAssignmentbttn.Text = "Start Task";
            StartAssignmentbttn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 961);
            Controls.Add(groupBox2);
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
            groupBox2.PerformLayout();
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
        private RichTextBox richTextBox1;
        private Label label5;
        private GroupBox groupBox2;
        private Button StartAssignmentbttn;
        private TextBox EndDatetxt;
        private Label label8;
        private TextBox StartDatetxt;
        private Label label7;
        private TextBox NameOfAssignmentWorkertxt;
        private Label label6;
        private ComboBox AssignmentClientcombox;
        private Label label9;
        private GroupBox groupBox3;
        private TextBox NameOfClienttxt;
        private Button Pauseassignmentbttn;
        private Button EndTaskbttn;
        private Label AssignmentInfoLbl;
    }
}