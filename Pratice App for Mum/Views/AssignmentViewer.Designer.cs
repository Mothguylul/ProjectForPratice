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
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // AssignmentPaused
            // 
            AssignmentPaused.AutoSize = true;
            AssignmentPaused.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            AssignmentPaused.Location = new Point(197, 19);
            AssignmentPaused.Name = "AssignmentPaused";
            AssignmentPaused.Size = new Size(130, 19);
            AssignmentPaused.TabIndex = 0;
            AssignmentPaused.Text = "Assignment Paused";
            AssignmentPaused.UseVisualStyleBackColor = true;
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StartDateLabel.Location = new Point(31, 19);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(54, 15);
            StartDateLabel.TabIndex = 1;
            StartDateLabel.Text = "Startdate";
            // 
            // EnddateLabel
            // 
            EnddateLabel.AutoSize = true;
            EnddateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EnddateLabel.Location = new Point(134, 19);
            EnddateLabel.Name = "EnddateLabel";
            EnddateLabel.Size = new Size(50, 15);
            EnddateLabel.TabIndex = 2;
            EnddateLabel.Text = "Enddate";
            // 
            // NotesAssignmentsLabel
            // 
            NotesAssignmentsLabel.AutoSize = true;
            NotesAssignmentsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NotesAssignmentsLabel.Location = new Point(95, 57);
            NotesAssignmentsLabel.Name = "NotesAssignmentsLabel";
            NotesAssignmentsLabel.Size = new Size(232, 15);
            NotesAssignmentsLabel.TabIndex = 4;
            NotesAssignmentsLabel.Text = "Hello I´m a professional papaplatte enjoyer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 18);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 5;
            label2.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 57);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Notes: ";
            // 
            // AssignmentViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(NotesAssignmentsLabel);
            Controls.Add(EnddateLabel);
            Controls.Add(StartDateLabel);
            Controls.Add(AssignmentPaused);
            Name = "AssignmentViewer";
            Size = new Size(776, 461);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox AssignmentPaused;
        private Label StartDateLabel;
        private Label EnddateLabel;
        private Label NotesAssignmentsLabel;
        private Label label2;
        private Label label1;
    }
}
