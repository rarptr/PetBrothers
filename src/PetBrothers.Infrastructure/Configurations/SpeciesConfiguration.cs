using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetBrothers.Domain.Species;

namespace PetBrothers.Infrastructure.Configurations;

public class SpeciesConfiguration : IEntityTypeConfiguration<Species>
{
    public void Configure(EntityTypeBuilder<Species> builder)
    {
        builder.ToTable("species");

        builder.HasKey(i => i.Id);

        builder.HasMany(s => s.Breeds)
            .WithOne(b => b.Species)
            .HasForeignKey("species_id")
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(i => i.Id)
            .HasConversion(
                id => id.Value,
                value => SpeciesId.Create(value));

        builder.ComplexProperty(m => m.Name, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Name.MAX_LENGTH)
                .HasColumnName("name");
        });

        builder.Property(p => p.CreatedDateTime)
            .IsRequired()
            .HasColumnName("created_date_time");
    }
}
