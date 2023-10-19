using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace MyApplication;

public partial class PhoneBookForm : Form
{
	public PhoneBookForm()
	{
		InitializeComponent();
	}

	private void PhoneBookForm_Load(object sender, EventArgs e)
	{
		RefreshContacts();
	}

	private void ExitButton_Click(object sender, EventArgs e)
	{
		var dialogResult =
		MessageBox.Show(
			text: "Do you want to exit the application?",
			caption: "Confirm application exit",
			buttons: MessageBoxButtons.YesNo,
			icon: MessageBoxIcon.Question,
			defaultButton: MessageBoxDefaultButton.Button2
			);
		if (dialogResult == DialogResult.Yes)
		{
			System.Windows.Forms.Application.Exit();
		}
	}

	private void AddButton_Click(object sender, EventArgs e)
	{
		var addContactForm = new AddContactForm(this);
		addContactForm.ShowDialog();
	}

	private List<Contacts> ContactList { get; set; }

	public void RefreshContacts()
	{
		var dbContext = new Persistence.DatabaseContext();
		ContactList = dbContext.Contacts.ToList();
		contactListDataGrid.DataSource = ContactList;
	}
}
