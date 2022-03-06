using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyStore.Domain.Account.Entities;

namespace MyStore.Infra.Persistence.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Email).IsRequired().HasMaxLength(160);
            builder.Property(x => x.Username).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(36).IsFixedLength();
            builder.Property(x => x.Verified);
            builder.Property(x => x.Active);
            builder.Property(x => x.LastLoginDate);
            builder.Property(x => x.Role);
            builder.Property(x => x.ActivationCode).HasMaxLength(4).IsFixedLength().IsRequired();
            builder.Property(x => x.VerificationCode).HasMaxLength(6).IsFixedLength().IsRequired();
            builder.Property(x => x.AuthorizationCode).HasMaxLength(4).IsFixedLength().IsRequired();
            builder.Property(x => x.LastAuthorizationCodeRequest);
        }
    }
}
