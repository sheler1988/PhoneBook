using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
	public partial class AddContactForm : Infrastructure.BaseForm
	{
		private PhoneBookForm _phoneBookForm;
		public AddContactForm(PhoneBookForm form)
		{
			InitializeComponent();
			_phoneBookForm = form;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var dbContext = new Persistence.DatabaseContext();
			var newContact = new Domain.Contacts();
			if (firstNameBox.Text is null)
			{
				
			}
			if (lastNameBox.Text is null)
			{

			}
			else
			{
				newContact.FirstName = firstNameBox.Text;
				newContact.LastName = lastNameBox.Text;
				newContact.CellPhoneNumber = cellPhoneNumberBox.Text;
				
				dbContext.Add(newContact);
				dbContext.SaveChanges();
			}
			_phoneBookForm.RefreshContacts();
			Close();
		}
	}
}
