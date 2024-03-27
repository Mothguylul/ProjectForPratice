namespace Pratice_App_for_Mum
{
    partial class CreateTown
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
            label1 = new Label();
            userInputText = new TextBox();
            CreateANewTown = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(430, 135);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 0;
            label1.Text = "Create Town";
            // 
            // userInputText
            // 
            userInputText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            userInputText.Location = new Point(314, 193);
            userInputText.Name = "userInputText";
            userInputText.Size = new Size(377, 33);
            userInputText.TabIndex = 1;
            // 
            // CreateANewTown
            // 
            CreateANewTown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateANewTown.Location = new Point(430, 248);
            CreateANewTown.Name = "CreateANewTown";
            CreateANewTown.Size = new Size(127, 42);
            CreateANewTown.TabIndex = 2;
            CreateANewTown.Text = "Add";
            CreateANewTown.UseVisualStyleBackColor = true;
            CreateANewTown.Click += CreateANewTown_Click;
            // 
            // CreateTown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 523);
            Controls.Add(CreateANewTown);
            Controls.Add(userInputText);
            Controls.Add(label1);
            Name = "CreateTown";
            Text = "CreateTown";
            Load += CreateTown_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userInputText;
        private Button CreateANewTown;
    }
}