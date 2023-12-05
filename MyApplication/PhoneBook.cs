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
using Microsoft.VisualBasic.ApplicationServices;
using Infrastructure;

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
		var addContactForm = new ContactForm(this);
		addContactForm.AcceptButton = addContactForm.saveButton;
		addContactForm.ShowDialog();
	}

	private List<Contacts> ContactList { get; set; }

	//to show a list of contacts
	public void RefreshContacts()
	{
		//to read or write from/to database 
		var dbContext = new Persistence.DatabaseContext();
		ContactList = dbContext.Contacts.OrderBy(c => c.FirstName).ToList();
		contactListDataGrid.DataSource = ContactList;
	}

	private void ContactListDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			Utility.CurrentContact = contactListDataGrid.Rows[e.RowIndex].DataBoundItem as Contacts;
			var contactInfo = new ContactForm(this);
			contactInfo.AcceptButton = contactInfo.editButton;

			contactInfo.firstNameBox.Text = Utility.CurrentContact.FirstName;
			contactInfo.lastNameBox.Text = Utility.CurrentContact.LastName;
			contactInfo.positionBox.Text = Utility.CurrentContact.Position;
			contactInfo.cellPhoneNumberBox.Text = Utility.CurrentContact.CellPhoneNumber;
			contactInfo.officePhoneNumberBox.Text = Utility.CurrentContact.OfficeNumber;
			contactInfo.emailBox.Text = Utility.CurrentContact.EmailAddress;

			contactInfo.firstNameBox.Enabled = false;
			contactInfo.lastNameBox.Enabled = false;
			contactInfo.positionBox.Enabled = false;
			contactInfo.cellPhoneNumberBox.Enabled = false;
			contactInfo.officePhoneNumberBox.Enabled = false;
			contactInfo.emailBox.Enabled = false;

			contactInfo.Text = "Contact Information";

			contactInfo.saveButton.Visible = false;
			contactInfo.resetButton.Visible = false;
			contactInfo.editButton.Visible = true;
			contactInfo.deleteButton.Visible = true;
			contactInfo.ShowDialog();
		}

	}

	private void SearchButton_Click(object sender, EventArgs e)
	{
		if (searchTextBox.Text == null || searchTextBox.Text == "")
		{
			RefreshContacts();
		}
		else
		{
			var dbContext = new Persistence.DatabaseContext();
			var searchResultContacts = new List<Domain.Contacts>();
			searchResultContacts = dbContext.Contacts.Where(c =>
			c.FirstName.Contains(searchTextBox.Text) ||
			c.LastName.Contains(searchTextBox.Text) ||
			c.Position.Contains(searchTextBox.Text) ||
			c.CellPhoneNumber.Contains(searchTextBox.Text) ||
			c.OfficeNumber.Contains(searchTextBox.Text)
			).ToList();

			contactListDataGrid.DataSource = searchResultContacts;
		}
	}
}
