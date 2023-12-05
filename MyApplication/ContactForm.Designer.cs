namespace MyApplication
{
	partial class ContactForm
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
			officePhoneNumberBox = new Dtat.Windows.Forms.TextBox();
			emailBox = new Dtat.Windows.Forms.TextBox();
			saveButton = new Dtat.Windows.Forms.Button();
			resetButton = new Dtat.Windows.Forms.Button();
			cancelButton = new Dtat.Windows.Forms.Button();
			editButton = new Dtat.Windows.Forms.Button();
			deleteButton = new Dtat.Windows.Forms.Button();
			SuspendLayout();
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Location = new Point(12, 9);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new Size(80, 20);
			firstNameLabel.TabIndex = 0;
			firstNameLabel.Text = "&First Name";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Location = new Point(12, 42);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(79, 20);
			lastNameLabel.TabIndex = 2;
			lastNameLabel.Text = "&Last Name";
			// 
			// positionLabel
			// 
			positionLabel.AutoSize = true;
			positionLabel.Location = new Point(12, 141);
			positionLabel.Name = "positionLabel";
			positionLabel.Size = new Size(61, 20);
			positionLabel.TabIndex = 8;
			positionLabel.Text = "&Position";
			// 
			// CellPhoneNumberLabel
			// 
			CellPhoneNumberLabel.AutoSize = true;
			CellPhoneNumberLabel.Location = new Point(12, 75);
			CellPhoneNumberLabel.Name = "CellPhoneNumberLabel";
			CellPhoneNumberLabel.Size = new Size(137, 20);
			CellPhoneNumberLabel.TabIndex = 4;
			CellPhoneNumberLabel.Text = "&Cell Phone Number";
			// 
			// officePhoneNumberLabel
			// 
			officePhoneNumberLabel.AutoSize = true;
			officePhoneNumberLabel.Location = new Point(12, 108);
			officePhoneNumberLabel.Name = "officePhoneNumberLabel";
			officePhoneNumberLabel.Size = new Size(152, 20);
			officePhoneNumberLabel.TabIndex = 6;
			officePhoneNumberLabel.Text = "&Office Phone Number";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Location = new Point(12, 174);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(46, 20);
			emailLabel.TabIndex = 10;
			emailLabel.Text = "&Email";
			// 
			// firstNameBox
			// 
			firstNameBox.Location = new Point(188, 6);
			firstNameBox.Name = "firstNameBox";
			firstNameBox.Size = new Size(294, 27);
			firstNameBox.TabIndex = 1;
			// 
			// lastNameBox
			// 
			lastNameBox.Location = new Point(188, 39);
			lastNameBox.Name = "lastNameBox";
			lastNameBox.Size = new Size(294, 27);
			lastNameBox.TabIndex = 3;
			// 
			// positionBox
			// 
			positionBox.Location = new Point(188, 138);
			positionBox.Name = "positionBox";
			positionBox.Size = new Size(294, 27);
			positionBox.TabIndex = 9;
			// 
			// cellPhoneNumberBox
			// 
			cellPhoneNumberBox.Location = new Point(188, 72);
			cellPhoneNumberBox.Name = "cellPhoneNumberBox";
			cellPhoneNumberBox.Size = new Size(294, 27);
			cellPhoneNumberBox.TabIndex = 5;
			// 
			// officePhoneNumberBox
			// 
			officePhoneNumberBox.Location = new Point(188, 105);
			officePhoneNumberBox.Name = "officePhoneNumberBox";
			officePhoneNumberBox.Size = new Size(294, 27);
			officePhoneNumberBox.TabIndex = 7;
			// 
			// emailBox
			// 
			emailBox.Location = new Point(188, 171);
			emailBox.Name = "emailBox";
			emailBox.Size = new Size(294, 27);
			emailBox.TabIndex = 11;
			// 
			// saveButton
			// 
			saveButton.Location = new Point(188, 204);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(94, 29);
			saveButton.TabIndex = 12;
			saveButton.Text = "&Save";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += SaveButton_Click;
			// 
			// resetButton
			// 
			resetButton.Location = new Point(288, 204);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(94, 29);
			resetButton.TabIndex = 14;
			resetButton.Text = "&Reset";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += ResetButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(388, 204);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(94, 29);
			cancelButton.TabIndex = 16;
			cancelButton.Text = "&Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += CancelButton_Click;
			// 
			// editButton
			// 
			editButton.Location = new Point(188, 204);
			editButton.Name = "editButton";
			editButton.Size = new Size(94, 29);
			editButton.TabIndex = 13;
			editButton.Text = "&Edit";
			editButton.UseVisualStyleBackColor = true;
			editButton.Visible = false;
			editButton.Click += EditButton_Click;
			// 
			// deleteButton
			// 
			deleteButton.Location = new Point(288, 204);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(94, 29);
			deleteButton.TabIndex = 15;
			deleteButton.Text = "&Delete";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Visible = false;
			deleteButton.Click += DeleteButton_Click;
			// 
			// ContactForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = cancelButton;
			ClientSize = new Size(494, 240);
			ControlBox = false;
			Controls.Add(deleteButton);
			Controls.Add(editButton);
			Controls.Add(cancelButton);
			Controls.Add(resetButton);
			Controls.Add(saveButton);
			Controls.Add(emailBox);
			Controls.Add(officePhoneNumberBox);
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
			MaximumSize = new Size(512, 287);
			MinimumSize = new Size(512, 287);
			Name = "ContactForm";
			Text = "Add New Contact";
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
		public Dtat.Windows.Forms.TextBox firstNameBox;
		public Dtat.Windows.Forms.TextBox lastNameBox;
		public Dtat.Windows.Forms.TextBox positionBox;
		public Dtat.Windows.Forms.TextBox cellPhoneNumberBox;
		public Dtat.Windows.Forms.TextBox officePhoneNumberBox;
		public Dtat.Windows.Forms.TextBox emailBox;
		public Dtat.Windows.Forms.Button saveButton;
		public Dtat.Windows.Forms.Button resetButton;
		public Dtat.Windows.Forms.Button cancelButton;
		public Dtat.Windows.Forms.Button editButton;
		public Dtat.Windows.Forms.Button deleteButton;
	}
}