namespace MyApplication
{
    partial class UpdateProfileForm
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
            saveButton = new Dtat.Windows.Forms.Button();
            resetButton = new Dtat.Windows.Forms.Button();
            fullNameTextBox = new Dtat.Windows.Forms.TextBox();
            fullNameLabel = new Dtat.Windows.Forms.Label();
            describtionLabel = new Dtat.Windows.Forms.Label();
            describtionTextBox = new Dtat.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(91, 140);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(75, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(172, 140);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(75, 23);
            resetButton.TabIndex = 5;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new System.Drawing.Point(91, 6);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new System.Drawing.Size(224, 23);
            fullNameTextBox.TabIndex = 1;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(12, 9);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(61, 15);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "&Full Name";
            // 
            // describtionLabel
            // 
            describtionLabel.AutoSize = true;
            describtionLabel.Location = new System.Drawing.Point(12, 42);
            describtionLabel.Name = "describtionLabel";
            describtionLabel.Size = new System.Drawing.Size(67, 15);
            describtionLabel.TabIndex = 2;
            describtionLabel.Text = "&Description";
            // 
            // describtionTextBox
            // 
            describtionTextBox.Location = new System.Drawing.Point(91, 39);
            describtionTextBox.Multiline = true;
            describtionTextBox.Name = "describtionTextBox";
            describtionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            describtionTextBox.Size = new System.Drawing.Size(224, 95);
            describtionTextBox.TabIndex = 3;
            // 
            // UpdateProfileForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(331, 174);
            Controls.Add(describtionTextBox);
            Controls.Add(describtionLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(fullNameTextBox);
            Controls.Add(resetButton);
            Controls.Add(saveButton);
            MaximumSize = new System.Drawing.Size(347, 213);
            MinimumSize = new System.Drawing.Size(347, 213);
            Name = "UpdateProfileForm";
            Text = "Update Profile";
            Load += UpdateProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Button saveButton;
        private Dtat.Windows.Forms.Button resetButton;
        private Dtat.Windows.Forms.TextBox fullNameTextBox;
        private Dtat.Windows.Forms.Label fullNameLabel;
        private Dtat.Windows.Forms.Label describtionLabel;
        private Dtat.Windows.Forms.TextBox describtionTextBox;
    }
}