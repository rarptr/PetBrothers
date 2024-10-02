using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetBrothers.Domain;
using PetBrothers.Domain.Volunteers;

namespace PetBrothers.Infrastructure.Configurations;

public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
{
    public void Configure(EntityTypeBuilder<Volunteer> builder)
    {
        builder.ToTable("volunteers");

        builder.HasKey(i => i.Id);

        builder.HasMany(v => v.OwnedPets)
            .WithOne()
            .HasForeignKey("volunteer_id")
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(i => i.Id)
            .HasConversion(
                id => id.Value,
                value => VolunteerId.Create(value));

        builder.ComplexProperty(m => m.FullName, tb =>
        {
            tb.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(FullName.FIRST_NAME_MAX_LENGTH)
                .HasColumnName("first_name");
            tb.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(FullName.LAST_NAME_MAX_LENGTH)
                .HasColumnName("last_name");
            tb.Property(p => p.MiddleName)
                .IsRequired()
                .HasMaxLength(FullName.MIDDLE_NAME_MAX_LENGTH)
                .HasColumnName("middle_name");
        });

        builder.ComplexProperty(m => m.Email, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Email.MAX_LENGTH)
                .HasColumnName("email");
        });

        builder.ComplexProperty(m => m.CommonDescription, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(CommonDescription.MAX_LENGTH)
                .HasColumnName("common_description");
        });

        builder.ComplexProperty(m => m.YearsExperience, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasColumnName("years_experience");
        });

        builder.ComplexProperty(m => m.PhoneNumber, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(PhoneNumber.MAX_LENGTH)
                .HasColumnName("phone_number");
        });

        builder.OwnsOne(p => p.VolunteerDetails, b =>
        {
            b.ToJson();
            b.OwnsMany(pd => pd.PaymentDetails, fb =>
            {
                fb.Property(f => f.Title)
                    .IsRequired()
                    .HasMaxLength(PaymentDetail.TITLE_MAX_LENGTH)
                    .HasColumnName("payment_title");
                fb.Property(f => f.Description)
                    .IsRequired()
                    .HasMaxLength(PaymentDetail.DESCRIPTION_MAX_LENGTH)
                    .HasColumnName("payment_description");
            });
            b.OwnsMany(pd => pd.SocialNetworks, fb =>
            {
                fb.Property(f => f.Title)
                    .IsRequired()
                    .HasMaxLength(SocialNetwork.TITLE_MAX_LENGTH)
                    .HasColumnName("social_network_title");
                fb.Property(f => f.Link)
                    .IsRequired()
                    .HasMaxLength(SocialNetwork.LINK_MAX_LENGTH)
                    .HasColumnName("social_network_link");
            });
        });
    }
}
