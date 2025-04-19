using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TermsManagement.Domain.StateEntity;

namespace TermsManagement.Infrastructure.Ef.Mappings;

public class StateMapping : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("States");
        builder.HasKey(key => key.Id);

        builder.Property(key => key.Title).IsRequired(true).HasMaxLength(150);
        builder.Property(key => key.CloseStates).IsRequired(false).HasMaxLength(100);

        builder.HasMany(model => model.Cities).WithOne(key => key.State)
            .HasForeignKey(key => key.StateId);
    }
}