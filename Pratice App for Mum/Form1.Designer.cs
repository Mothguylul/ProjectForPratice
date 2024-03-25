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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            NameTextBox = new TextBox();
            label2 = new Label();
            EmailTextBox = new TextBox();
            label3 = new Label();
            BirthDateTextBox = new TextBox();
            label4 = new Label();
            MobilTextBox = new TextBox();
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
            TownComboBox.Location = new Point(421, 108);
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
            WorkersListBox.Location = new Point(421, 152);
            WorkersListBox.Name = "WorkersListBox";
            WorkersListBox.Size = new Size(157, 364);
            WorkersListBox.TabIndex = 72;
            WorkersListBox.SelectedIndexChanged += WorkersListBox_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(584, 108);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(393, 408);
            richTextBox1.TabIndex = 73;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(592, 121);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 74;
            label1.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(653, 115);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(313, 33);
            NameTextBox.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(592, 165);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 76;
            label2.Text = "Email:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.Location = new Point(653, 159);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(313, 33);
            EmailTextBox.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(592, 212);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 78;
            label3.Text = "Birthdate:";
            // 
            // BirthDateTextBox
            // 
            BirthDateTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BirthDateTextBox.Location = new Point(674, 206);
            BirthDateTextBox.Name = "BirthDateTextBox";
            BirthDateTextBox.Size = new Size(292, 33);
            BirthDateTextBox.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(592, 259);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 80;
            label4.Text = "Mobil:";
            // 
            // MobilTextBox
            // 
            MobilTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MobilTextBox.Location = new Point(653, 251);
            MobilTextBox.Name = "MobilTextBox";
            MobilTextBox.Size = new Size(313, 33);
            MobilTextBox.TabIndex = 81;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 961);
            Controls.Add(MobilTextBox);
            Controls.Add(label4);
            Controls.Add(BirthDateTextBox);
            Controls.Add(label3);
            Controls.Add(EmailTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
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
        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox NameTextBox;
        private Label label2;
        private TextBox EmailTextBox;
        private Label label3;
        private TextBox BirthDateTextBox;
        private Label label4;
        private TextBox MobilTextBox;
    }
}