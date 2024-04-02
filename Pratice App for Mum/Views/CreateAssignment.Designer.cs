namespace Pratice_App_for_Mum.Views
{
    partial class CreateAssignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Startdatetxt = new TextBox();
            Nametxt = new Label();
            NotesRichtxt = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            Enddatetxt = new TextBox();
            label3 = new Label();
            label5 = new Label();
            Startbttn = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            NameLabel = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Startdatetxt
            // 
            Startdatetxt.Location = new Point(27, 81);
            Startdatetxt.Name = "Startdatetxt";
            Startdatetxt.Size = new Size(111, 33);
            Startdatetxt.TabIndex = 0;
            // 
            // Nametxt
            // 
            Nametxt.AutoSize = true;
            Nametxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nametxt.Location = new Point(38, 46);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(55, 21);
            Nametxt.TabIndex = 1;
            Nametxt.Text = "Name:";
            // 
            // NotesRichtxt
            // 
            NotesRichtxt.Location = new Point(378, 102);
            NotesRichtxt.Name = "NotesRichtxt";
            NotesRichtxt.Size = new Size(301, 125);
            NotesRichtxt.TabIndex = 2;
            NotesRichtxt.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 57);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 5;
            label1.Text = "Enddate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 54);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 6;
            label2.Text = "Startdate";
            // 
            // Enddatetxt
            // 
            Enddatetxt.Location = new Point(170, 81);
            Enddatetxt.Name = "Enddatetxt";
            Enddatetxt.Size = new Size(111, 33);
            Enddatetxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 81);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 8;
            label3.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(378, 74);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 10;
            label5.Text = "Notes:";
            // 
            // Startbttn
            // 
            Startbttn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Startbttn.Location = new Point(539, 292);
            Startbttn.Name = "Startbttn";
            Startbttn.Size = new Size(140, 42);
            Startbttn.TabIndex = 11;
            Startbttn.Text = "Start";
            Startbttn.UseVisualStyleBackColor = true;
            Startbttn.Click += Startbttn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 273);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 245);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 13;
            label6.Text = "Client:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NameLabel.Location = new Point(108, 46);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(53, 21);
            NameLabel.TabIndex = 14;
            NameLabel.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(281, 9);
            label7.Name = "label7";
            label7.Size = new Size(220, 32);
            label7.TabIndex = 15;
            label7.Text = "Create Assignment";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Startdatetxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Enddatetxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(38, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 143);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Timeframe";
            // 
            // CreateAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 346);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(NameLabel);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(Startbttn);
            Controls.Add(label5);
            Controls.Add(NotesRichtxt);
            Controls.Add(Nametxt);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CreateAssignment";
            Text = "CreateAssignment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Startdatetxt;
        private Label Nametxt;
        private RichTextBox NotesRichtxt;
        private Label label1;
        private Label label2;
        private TextBox Enddatetxt;
        private Label label3;
        private Label label5;
        private Button Startbttn;
        private ComboBox comboBox1;
        private Label label6;
        private Label NameLabel;
        private Label label7;
        private GroupBox groupBox1;
    }
}