using CustomerData.CrossCuttingConcerns.Identity;
using CustomerData.CrossCuttingConcerns.OS;
using CustomerData.Domain.Common;
using CustomerData.Domain.Entities;
using CustomerData.Persistence.Context.Seeds.Application;
using CustomerData.Persistence.Context.Seeds.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>//AuditableContext
    {
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IDateTimeProvider _dateTimeProvider;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
            ILoggedInUserService loggedInUserService,
            IDateTimeProvider dateTimeProvider)
           : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _loggedInUserService = loggedInUserService;
            _dateTimeProvider = dateTimeProvider;
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUserLogin<string>>().HasKey(x => new { x.UserId, x.LoginProvider });

            #region Custom Identity table names
            //builder.HasDefaultSchema("Identity");
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("User", "Identity");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("Role", "Identity");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles", "Identity");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims", "Identity");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins", "Identity");
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims", "Identity");
            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens", "Identity");
            });
            #endregion

            builder.IdentitySeed();

            foreach (var property in builder.Model.GetEntityTypes()
           .SelectMany(t => t.GetProperties())
           .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,2)");
            }

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            builder.ApplicationSeed();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _loggedInUserService.UserId;
                        entry.Entity.CreatedDate = _dateTimeProvider.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _loggedInUserService.UserId;
                        entry.Entity.LastModifiedDate = _dateTimeProvider.UtcNow;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);

            //if (_loggedInUserService.UserId == null)
            //{
              //  return await base.SaveChangesAsync(cancellationToken);
           // }
            //else
           // {
               // return await base.SaveChangesAsync(_loggedInUserService.UserId);
            //}
        }
    }
}
