using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Contacts : SeedWork.Entity
{
	#region Constructor
	//public User() : base()
	//{
	//}

	public Contacts() : base()
	{
	}
	#endregion /Constructor

	#region public bool IsActive { get; set; }
	/// <summary>
	/// فعال است
	/// </summary>
	[Browsable(false)]
	[System.ComponentModel.DisplayName
		(displayName: "Active")]
	public bool IsActive { get; set; }
	#endregion /public bool IsActive { get; set; }

	[DisplayName(displayName: "First Name")]
	[Display(Name = "First Name")]
	[MaxLength(length: 50)]
	public string? FirstName { get; set; }

	[DisplayName(displayName: "Last Name")]
	[Display(Name = "Last Name")]
	[MaxLength(length: 50)]
	public string? LastName { get; set; }

	[DisplayName(displayName: "Position")]
	[Display(Name = "Position")]
	[MaxLength(length: 200)]
	public string? Position { get; set; }

	[System.ComponentModel.Browsable(browsable: false)]
	[DisplayName(displayName: "Phone Number")]
	[Display(Name = "Phone Number")]
	[MaxLength(length: 20)]
	public string? CellPhoneNumber { get; set; }

	[System.ComponentModel.Browsable(browsable: false)]
	[DisplayName(displayName: "Office Number")]
	[Display(Name = "Office Number")]
	[MaxLength(length: 20)]
	public string? OfficeNumber { get; set; }

	[System.ComponentModel.Browsable(browsable: false)]
	[DisplayName(displayName: "Email Address")]
	[Display(Name = "Email Address")]
	[MaxLength(length: 500)]
	public string? EmailAddress { get; set; }
}
