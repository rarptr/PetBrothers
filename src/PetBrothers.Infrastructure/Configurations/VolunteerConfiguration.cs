using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetBrothers.Domain.Shared;
using PetBrothers.Domain.Volunteers;

namespace PetBrothers.Infrastructure.Configurations;

public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
{
    public void Configure(EntityTypeBuilder<Volunteer> builder)
    {
        builder.ToTable("volunteers");

        builder.HasKey(i => i.Id);

        builder.HasMany(v => v.OwnedPets)
            .WithOne(p => p.Volunteer)
            .HasForeignKey("volunteer_id");

        builder.ComplexProperty(m => m.FullName, tb =>
        {
            tb.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("first_name");
            tb.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("last_name");
            tb.Property(p => p.MiddleName)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("middle_name");
        });


        builder.ComplexProperty(m => m.Email, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("email");
        });

        builder.ComplexProperty(m => m.CommonDescription, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_MEDIUM_LENGTH)
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
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("phone_number");
        });

        builder.OwnsOne(p => p.VolunteerDetails, b =>
        {
            b.ToJson();
            b.OwnsMany(pd => pd.PaymentDetails, fb =>
            {
                fb.Property(f => f.Title)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                    .HasColumnName("payment_title");
                fb.Property(f => f.Description)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_MEDIUM_LENGTH)
                    .HasColumnName("payment_description");
            });
            b.OwnsMany(pd => pd.SocialNetworks, fb =>
            {
                fb.Property(f => f.Title)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                    .HasColumnName("social_network_title");
                fb.Property(f => f.Link)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_MEDIUM_LENGTH)
                    .HasColumnName("social_network_link");
            });
        });
    }
}
