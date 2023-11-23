namespace MyApplication
{
	partial class PhoneBookForm
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
			addButton = new Dtat.Windows.Forms.Button();
			searchButton = new Dtat.Windows.Forms.Button();
			contactListDataGrid = new Dtat.Windows.Forms.DataGridView();
			exitButton = new Dtat.Windows.Forms.Button();
			textBox1 = new Dtat.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)contactListDataGrid).BeginInit();
			SuspendLayout();
			// 
			// addButton
			// 
			addButton.Anchor = AnchorStyles.None;
			addButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			addButton.Location = new Point(12, 486);
			addButton.Name = "addButton";
			addButton.Size = new Size(132, 40);
			addButton.TabIndex = 0;
			addButton.Text = "&Add";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += AddButton_Click;
			// 
			// searchButton
			// 
			searchButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			searchButton.Location = new Point(178, 486);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(132, 40);
			searchButton.TabIndex = 1;
			searchButton.Text = "&Search";
			searchButton.UseVisualStyleBackColor = true;
			// 
			// contactListDataGrid
			// 
			contactListDataGrid.AllowUserToAddRows = false;
			contactListDataGrid.AllowUserToDeleteRows = false;
			contactListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			contactListDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
			contactListDataGrid.Location = new Point(12, 12);
			contactListDataGrid.MultiSelect = false;
			contactListDataGrid.Name = "contactListDataGrid";
			contactListDataGrid.ReadOnly = true;
			contactListDataGrid.RowHeadersVisible = false;
			contactListDataGrid.RowHeadersWidth = 51;
			contactListDataGrid.RowTemplate.Height = 29;
			contactListDataGrid.Size = new Size(460, 455);
			contactListDataGrid.TabIndex = 2;
			contactListDataGrid.CellContentDoubleClick += ContactListDataGrid_CellContentDoubleClick;
			// 
			// exitButton
			// 
			exitButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			exitButton.Location = new Point(710, 486);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(132, 40);
			exitButton.TabIndex = 3;
			exitButton.Text = "&Exit";
			exitButton.UseVisualStyleBackColor = true;
			exitButton.Click += ExitButton_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(502, 184);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(325, 65);
			textBox1.TabIndex = 4;
			// 
			// PhoneBookForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(932, 557);
			Controls.Add(textBox1);
			Controls.Add(exitButton);
			Controls.Add(contactListDataGrid);
			Controls.Add(searchButton);
			Controls.Add(addButton);
			MinimumSize = new Size(0, 180);
			Name = "PhoneBookForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PhoneBook";
			Load += PhoneBookForm_Load;
			((System.ComponentModel.ISupportInitialize)contactListDataGrid).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Dtat.Windows.Forms.Button addButton;
		private Dtat.Windows.Forms.Button searchButton;
		private Dtat.Windows.Forms.DataGridView contactListDataGrid;
		private Dtat.Windows.Forms.Button exitButton;
		private Dtat.Windows.Forms.TextBox textBox1;
	}
}