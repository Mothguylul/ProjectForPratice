namespace Pratice_App_for_Mum.Views
{
    partial class NewAssignmentViewer
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
            Startdate = new Label();
            Enddate = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            Noteslabel = new Label();
            SuspendLayout();
            // 
            // Startdate
            // 
            Startdate.AutoSize = true;
            Startdate.Location = new Point(43, 61);
            Startdate.Name = "Startdate";
            Startdate.Size = new Size(54, 15);
            Startdate.TabIndex = 0;
            Startdate.Text = "Startdate";
            // 
            // Enddate
            // 
            Enddate.AutoSize = true;
            Enddate.Location = new Point(164, 61);
            Enddate.Name = "Enddate";
            Enddate.Size = new Size(50, 15);
            Enddate.TabIndex = 1;
            Enddate.Text = "Enddate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 61);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 2;
            label1.Text = "-";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(259, 61);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Paused";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 100);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Notes";
            // 
            // Noteslabel
            // 
            Noteslabel.AutoSize = true;
            Noteslabel.Location = new Point(43, 115);
            Noteslabel.Name = "Noteslabel";
            Noteslabel.Size = new Size(232, 15);
            Noteslabel.TabIndex = 5;
            Noteslabel.Text = "Hello I´m a professional papaplatte enjoyer";
            // 
            // NewAssignmentViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Noteslabel);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(Enddate);
            Controls.Add(Startdate);
            Name = "NewAssignmentViewer";
            Size = new Size(357, 166);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Startdate;
        private Label Enddate;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private Label Noteslabel;
    }
}
