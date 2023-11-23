using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure;

namespace MyApplication
{
	public partial class ContactForm : Infrastructure.BaseForm
	{
		private PhoneBookForm _phoneBookForm;
		public ContactForm(PhoneBookForm form)
		{
			InitializeComponent();
			_phoneBookForm = form;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var dbContext = new Persistence.DatabaseContext();
			var newContact = new Domain.Contacts();
			firstNameBox.Text = Infrastructure.Utility.FixText(firstNameBox.Text);
			lastNameBox.Text = Infrastructure.Utility.FixText(lastNameBox.Text);
			if (firstNameBox.Text == string.Empty || lastNameBox.Text == string.Empty)
			{
				var errorMassage = "First name/Last name can not be empty!";
				System.Windows.Forms.MessageBox.Show(errorMassage);
				return;
			}
			if (Infrastructure.Utility.CurrentContact == null)
			{
				newContact.FirstName = firstNameBox.Text;
				newContact.LastName = lastNameBox.Text;
				newContact.CellPhoneNumber = cellPhoneNumberBox.Text;
				newContact.OfficeNumber = officePhoneNumberBox.Text;
				newContact.EmailAddress = emailBox.Text;
				newContact.Position = positionBox.Text;
				dbContext.Add(newContact);
				dbContext.SaveChanges();
				System.Windows.Forms.MessageBox.Show("New cantact added successfully!");
			}
			else
			{
				var contact = dbContext.Contacts.Where(c => c.Id == Utility.CurrentContact.Id).FirstOrDefault();
				if (contact != null)
				{
					contact.FirstName = firstNameBox.Text;
					contact.LastName = lastNameBox.Text;
					contact.CellPhoneNumber = cellPhoneNumberBox.Text;
					contact.OfficeNumber = officePhoneNumberBox.Text;
					contact.EmailAddress = emailBox.Text;
					contact.Position = positionBox.Text;
					dbContext.Update(contact);
					dbContext.SaveChanges();
					System.Windows.Forms.MessageBox.Show("All chenges saved successfully!");
				}
			}
			_phoneBookForm.RefreshContacts();
			this.Dispose();
			Close();
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			if (Utility.CurrentContact is null)
			{
				ResetAddContactForm();
			}
			else
			{
				ResetEditContactForm();
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			if (Utility.CurrentContact is not null)
			{
				Utility.CurrentContact = null;
			}
			this.Dispose();
			Close();
		}
		private void ResetAddContactForm()
		{
			firstNameBox.ResetText();
			lastNameBox.ResetText();
			emailBox.ResetText();
			positionBox.ResetText();
			cellPhoneNumberBox.ResetText();
			officePhoneNumberBox.ResetText();

			firstNameBox.Focus();
		}

		private void ResetEditContactForm()
		{
			firstNameBox.Text = Utility.CurrentContact.FirstName;
			lastNameBox.Text = Utility.CurrentContact.LastName;
			emailBox.Text = Utility.CurrentContact.EmailAddress;
			positionBox.Text = Utility.CurrentContact.Position;
			cellPhoneNumberBox.Text = Utility.CurrentContact.CellPhoneNumber;
			officePhoneNumberBox.Text = Utility.CurrentContact.OfficeNumber;

			firstNameBox.Focus();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			firstNameBox.Enabled = true;
			lastNameBox.Enabled = true;
			positionBox.Enabled = true;
			cellPhoneNumberBox.Enabled = true;
			officePhoneNumberBox.Enabled = true;
			emailBox.Enabled = true;

			editButton.Visible = false;
			deleteButton.Visible = false;
			saveButton.Visible = true;
			resetButton.Visible = true;
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			var dialogResult =
			System.Windows.Forms.MessageBox.Show(text:"Are you sure to delete this contact?",
				caption:"Delete Verification",
				buttons:MessageBoxButtons.YesNo,
				icon:MessageBoxIcon.Question,
				defaultButton:MessageBoxDefaultButton.Button2);

			if (dialogResult == DialogResult.Yes)
			{
				

			var dbContext = new Persistence.DatabaseContext();
			if (Utility.CurrentContact != null )
			{
				var contact = dbContext.Contacts.Where
					(c => c.Id == Utility.CurrentContact.Id).FirstOrDefault();
				if ( contact != null )
				{
					dbContext.Contacts.Remove( contact );
					dbContext.SaveChanges();
					Utility.CurrentContact = null;
				}
			}

			_phoneBookForm.RefreshContacts();
			this.Dispose();
				Close();
			}
		}
	}
}
