namespace Pratice_App_for_Mum.Views
{
    partial class AssignmentViewer
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            AssignmentPaused = new CheckBox();
            StartDateLabel = new Label();
            EnddateLabel = new Label();
            NotesAssignmentsLabel = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AssignmentPaused
            // 
            AssignmentPaused.AutoSize = true;
            AssignmentPaused.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            AssignmentPaused.Location = new Point(168, 73);
            AssignmentPaused.Name = "AssignmentPaused";
            AssignmentPaused.Size = new Size(152, 24);
            AssignmentPaused.TabIndex = 0;
            AssignmentPaused.Text = "Assignment Paused";
            AssignmentPaused.UseVisualStyleBackColor = true;
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartDateLabel.Location = new Point(53, 42);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(70, 20);
            StartDateLabel.TabIndex = 1;
            StartDateLabel.Text = "Startdate";
            // 
            // EnddateLabel
            // 
            EnddateLabel.AutoSize = true;
            EnddateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EnddateLabel.Location = new Point(54, 63);
            EnddateLabel.Name = "EnddateLabel";
            EnddateLabel.Size = new Size(64, 20);
            EnddateLabel.TabIndex = 2;
            EnddateLabel.Text = "Enddate";
            // 
            // NotesAssignmentsLabel
            // 
            NotesAssignmentsLabel.AutoSize = true;
            NotesAssignmentsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NotesAssignmentsLabel.Location = new Point(3, 10);
            NotesAssignmentsLabel.Name = "NotesAssignmentsLabel";
            NotesAssignmentsLabel.Size = new Size(0, 20);
            NotesAssignmentsLabel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 83);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 6;
            label1.Text = "Notes: ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(NotesAssignmentsLabel);
            panel1.Location = new Point(9, 103);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 41);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 21);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Client: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(60, 21);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 10;
            label5.Text = "Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 63);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 11;
            label2.Text = "End:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 42);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 12;
            label3.Text = "Start:";
            // 
            // AssignmentViewer
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(EnddateLabel);
            Controls.Add(StartDateLabel);
            Controls.Add(AssignmentPaused);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "AssignmentViewer";
            Size = new Size(333, 156);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox AssignmentPaused;
        private Label StartDateLabel;
        private Label EnddateLabel;
        private Label NotesAssignmentsLabel;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label3;
    }
}
