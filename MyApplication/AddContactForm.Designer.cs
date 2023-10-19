namespace MyApplication
{
	partial class AddContactForm
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
			firstNameLabel = new Dtat.Windows.Forms.Label();
			lastNameLabel = new Dtat.Windows.Forms.Label();
			positionLabel = new Dtat.Windows.Forms.Label();
			CellPhoneNumberLabel = new Dtat.Windows.Forms.Label();
			officePhoneNumberLabel = new Dtat.Windows.Forms.Label();
			emailLabel = new Dtat.Windows.Forms.Label();
			firstNameBox = new Dtat.Windows.Forms.TextBox();
			lastNameBox = new Dtat.Windows.Forms.TextBox();
			positionBox = new Dtat.Windows.Forms.TextBox();
			cellPhoneNumberBox = new Dtat.Windows.Forms.TextBox();
			officePhoneNumberBox5 = new Dtat.Windows.Forms.TextBox();
			emailBox = new Dtat.Windows.Forms.TextBox();
			saveButton = new Dtat.Windows.Forms.Button();
			resetButton = new Dtat.Windows.Forms.Button();
			canselButton = new Dtat.Windows.Forms.Button();
			SuspendLayout();
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Location = new Point(25, 21);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new Size(80, 20);
			firstNameLabel.TabIndex = 0;
			firstNameLabel.Text = "&First Name";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Location = new Point(26, 55);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(79, 20);
			lastNameLabel.TabIndex = 1;
			lastNameLabel.Text = "&Last Name";
			// 
			// positionLabel
			// 
			positionLabel.AutoSize = true;
			positionLabel.Location = new Point(26, 99);
			positionLabel.Name = "positionLabel";
			positionLabel.Size = new Size(61, 20);
			positionLabel.TabIndex = 2;
			positionLabel.Text = "&Position";
			// 
			// CellPhoneNumberLabel
			// 
			CellPhoneNumberLabel.AutoSize = true;
			CellPhoneNumberLabel.Location = new Point(26, 141);
			CellPhoneNumberLabel.Name = "CellPhoneNumberLabel";
			CellPhoneNumberLabel.Size = new Size(137, 20);
			CellPhoneNumberLabel.TabIndex = 3;
			CellPhoneNumberLabel.Text = "&Cell Phone Number";
			// 
			// officePhoneNumberLabel
			// 
			officePhoneNumberLabel.AutoSize = true;
			officePhoneNumberLabel.Location = new Point(37, 180);
			officePhoneNumberLabel.Name = "officePhoneNumberLabel";
			officePhoneNumberLabel.Size = new Size(152, 20);
			officePhoneNumberLabel.TabIndex = 4;
			officePhoneNumberLabel.Text = "&Office Phone Number";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Location = new Point(37, 232);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(46, 20);
			emailLabel.TabIndex = 5;
			emailLabel.Text = "&Email";
			// 
			// firstNameBox
			// 
			firstNameBox.Location = new Point(157, 18);
			firstNameBox.Name = "firstNameBox";
			firstNameBox.Size = new Size(125, 27);
			firstNameBox.TabIndex = 6;
			// 
			// lastNameBox
			// 
			lastNameBox.Location = new Point(157, 55);
			lastNameBox.Name = "lastNameBox";
			lastNameBox.Size = new Size(125, 27);
			lastNameBox.TabIndex = 7;
			// 
			// positionBox
			// 
			positionBox.Location = new Point(157, 92);
			positionBox.Name = "positionBox";
			positionBox.Size = new Size(125, 27);
			positionBox.TabIndex = 8;
			// 
			// cellPhoneNumberBox
			// 
			cellPhoneNumberBox.Location = new Point(188, 138);
			cellPhoneNumberBox.Name = "cellPhoneNumberBox";
			cellPhoneNumberBox.Size = new Size(125, 27);
			cellPhoneNumberBox.TabIndex = 9;
			// 
			// officePhoneNumberBox5
			// 
			officePhoneNumberBox5.Location = new Point(188, 180);
			officePhoneNumberBox5.Name = "officePhoneNumberBox5";
			officePhoneNumberBox5.Size = new Size(125, 27);
			officePhoneNumberBox5.TabIndex = 10;
			// 
			// emailBox
			// 
			emailBox.Location = new Point(157, 225);
			emailBox.Name = "emailBox";
			emailBox.Size = new Size(125, 27);
			emailBox.TabIndex = 11;
			// 
			// saveButton
			// 
			saveButton.Location = new Point(53, 368);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(94, 29);
			saveButton.TabIndex = 12;
			saveButton.Text = "&Save";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += SaveButton_Click;
			// 
			// resetButton
			// 
			resetButton.Location = new Point(184, 376);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(94, 29);
			resetButton.TabIndex = 13;
			resetButton.Text = "&Reset";
			resetButton.UseVisualStyleBackColor = true;
			// 
			// canselButton
			// 
			canselButton.Location = new Point(355, 383);
			canselButton.Name = "canselButton";
			canselButton.Size = new Size(94, 29);
			canselButton.TabIndex = 14;
			canselButton.Text = "&Cansel";
			canselButton.UseVisualStyleBackColor = true;
			// 
			// AddContactForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(canselButton);
			Controls.Add(resetButton);
			Controls.Add(saveButton);
			Controls.Add(emailBox);
			Controls.Add(officePhoneNumberBox5);
			Controls.Add(cellPhoneNumberBox);
			Controls.Add(positionBox);
			Controls.Add(lastNameBox);
			Controls.Add(firstNameBox);
			Controls.Add(emailLabel);
			Controls.Add(officePhoneNumberLabel);
			Controls.Add(CellPhoneNumberLabel);
			Controls.Add(positionLabel);
			Controls.Add(lastNameLabel);
			Controls.Add(firstNameLabel);
			Name = "AddContactForm";
			Text = "Add Contact";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Dtat.Windows.Forms.Label firstNameLabel;
		private Dtat.Windows.Forms.Label lastNameLabel;
		private Dtat.Windows.Forms.Label positionLabel;
		private Dtat.Windows.Forms.Label CellPhoneNumberLabel;
		private Dtat.Windows.Forms.Label officePhoneNumberLabel;
		private Dtat.Windows.Forms.Label emailLabel;
		private Dtat.Windows.Forms.TextBox firstNameBox;
		private Dtat.Windows.Forms.TextBox lastNameBox;
		private Dtat.Windows.Forms.TextBox positionBox;
		private Dtat.Windows.Forms.TextBox cellPhoneNumberBox;
		private Dtat.Windows.Forms.TextBox officePhoneNumberBox5;
		private Dtat.Windows.Forms.TextBox emailBox;
		private Dtat.Windows.Forms.Button saveButton;
		private Dtat.Windows.Forms.Button resetButton;
		private Dtat.Windows.Forms.Button canselButton;
	}
}