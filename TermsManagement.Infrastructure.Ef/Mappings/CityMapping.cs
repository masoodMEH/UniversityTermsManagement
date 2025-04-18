using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TermsManagement.Domain.CityEntity;

namespace TermsManagement.Infrastructure.Ef.Mappings;

public class CityMapping : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("Cities");
        builder.HasKey(key => key.Id);

        builder.Property(key => key.Title).IsRequired(true).HasMaxLength(150);
        builder.Property(key => key.Center).IsRequired(true);
        builder.Property(key => key.StateId).IsRequired(true);
        builder.Property(key => key.Tehran).IsRequired(true);
        builder.Property(key => key.CreateDate).IsRequired(true);

        builder.HasOne(model => model.State).WithMany(key => key.Cities).HasForeignKey(key => key.StateId);
    }
}
