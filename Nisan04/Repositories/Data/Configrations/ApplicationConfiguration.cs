using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
{
    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Bootcamp)
            .WithMany(x => x.Applications)
            .HasForeignKey(x => x.BootcampId);
    }
}