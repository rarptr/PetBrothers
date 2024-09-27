using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetBrothers.Domain.Shared;
using PetBrothers.Domain.Volunteers.Pets;

namespace PetBrothers.Infrastructure.Configurations;

public class PetConfiguration : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.ToTable("pets");

        builder.HasKey(i => i.Id);

        builder.HasOne(p => p.Volunteer)
            .WithMany(v => v.OwnedPets)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);

        builder.ComplexProperty(m => m.Name, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("name");
        });

        builder.ComplexProperty(m => m.Species, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("species");
        });

        builder.ComplexProperty(m => m.Description, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_MEDIUM_LENGTH)
                .HasColumnName("description");
        });

        builder.ComplexProperty(m => m.Breed, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("breed");
        });

        builder.ComplexProperty(m => m.Colour, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("colour");
        });

        builder.ComplexProperty(m => m.HealthInformation, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LARGE_LENGTH)
                .HasColumnName("health_information");
        });

        builder.ComplexProperty(m => m.CurrentAddress, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_MEDIUM_LENGTH)
                .HasColumnName("current_address");
        });

        builder.ComplexProperty(m => m.Weight, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasColumnName("weight");
        });

        builder.ComplexProperty(m => m.Height, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasColumnName("height");
        });

        builder.ComplexProperty(m => m.OwnerPhoneNumber, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.MAX_SMALL_LENGTH)
                .HasColumnName("owner_phone_number");
        });

        builder.ComplexProperty(m => m.IsCastrated, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasColumnName("is_castrated");
        });

        // Конвертирование значения для хранения в бд и извлечения из бд
        builder.Property(p => p.BirthDate)
            .HasConversion(
                v => v.Value.ToDateTime(TimeOnly.MinValue), // Преобразование из DateOnly в DateTime
                v => BirthDate.Create(DateOnly.FromDateTime(v)).Value // Преобразование из DateTime в DateOnly
            )
            .HasColumnName("birth_date"); // Добавлено имя столбца для BirthDate

        builder.ComplexProperty(m => m.IsVaccinated, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasColumnName("is_vaccinated");
        });

        builder.Property(p => p.AssistanceStatus)
            .IsRequired()
            .HasColumnName("assistance_status");

        builder.Property(p => p.CreatedDateTime)
            .IsRequired()
            .HasColumnName("created_date_time");

        builder.OwnsOne(p => p.PetDetails, b =>
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
        });
    }
}
