using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class UserConfiguration : object, IEntityTypeConfiguration<Domain.Contacts>
{
	public UserConfiguration() : base()
	{
	}

	public void Configure(Microsoft.EntityFrameworkCore
		.Metadata.Builders.EntityTypeBuilder<Domain.Contacts> builder)
	{
		// **************************************************
		// **************************************************
		// **************************************************
		builder
			.Property(current => current.FirstName)
			.IsUnicode(unicode: true)
			;

		builder
			.HasIndex(current => current.LastName)
			.IsUnique(unique: true)
			;
		// **************************************************

		// **************************************************
		builder
			.Property(current => current.Position)
			.IsUnicode(unicode: true)
			;
		// **************************************************

		// **************************************************
		builder
			.Property(current =>current.CellPhoneNumber)
			;
		// **************************************************
		// **************************************************
		// **************************************************
		builder
			.Property(current =>current.OfficeNumber)
			;

		// **************************************************
		// **************************************************
		// **************************************************
		builder
			.Property(current => current.EmailAddress)
			;
		
		// **************************************************
		// **************************************************
		// **************************************************
	}
}
