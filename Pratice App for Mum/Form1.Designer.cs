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
            WorkersListBox.Size = new Size(157, 424);
            WorkersListBox.TabIndex = 72;
            WorkersListBox.SelectedIndexChanged += WorkersListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(565, 152);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 74;
            label1.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(626, 146);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(309, 33);
            NameTextBox.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(565, 193);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 76;
            label2.Text = "Email:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.Location = new Point(626, 193);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(309, 33);
            EmailTextBox.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(567, 280);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 78;
            label3.Text = "Birthdate:";
            // 
            // BirthDateTextBox
            // 
            BirthDateTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BirthDateTextBox.Location = new Point(647, 274);
            BirthDateTextBox.Name = "BirthDateTextBox";
            BirthDateTextBox.Size = new Size(288, 33);
            BirthDateTextBox.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(567, 238);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 80;
            label4.Text = "Mobil:";
            // 
            // MobilTextBox
            // 
            MobilTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MobilTextBox.Location = new Point(626, 232);
            MobilTextBox.Name = "MobilTextBox";
            MobilTextBox.Size = new Size(309, 33);
            MobilTextBox.TabIndex = 81;
            // 
            // CreateTownNutton
            // 
            CreateTownNutton.BackColor = SystemColors.ControlDark;
            CreateTownNutton.Location = new Point(421, 111);
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
            DeleteTownButton.Location = new Point(149, 108);
            DeleteTownButton.Name = "DeleteTownButton";
            DeleteTownButton.Size = new Size(103, 41);
            DeleteTownButton.TabIndex = 83;
            DeleteTownButton.Text = "Delete";
            DeleteTownButton.UseVisualStyleBackColor = false;
            DeleteTownButton.Click += DeleteTownButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 961);
            Controls.Add(DeleteTownButton);
            Controls.Add(CreateTownNutton);
            Controls.Add(MobilTextBox);
            Controls.Add(label4);
            Controls.Add(BirthDateTextBox);
            Controls.Add(label3);
            Controls.Add(EmailTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Controls.Add(WorkersListBox);
            Controls.Add(TownComboBox);
            Controls.Add(label25);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
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
    }
}