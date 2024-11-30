using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_Identity.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser, ApplicationRole, int>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<ApplicationRole>().HasData(
            new List<ApplicationRole>()
        {
            new()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
            },
            new()
            {
                Id = 2,
                Name = "User",
                NormalizedName = "USER",
            }
        }
        );
        builder.Entity<ApplicationUser>().HasData(
            new List<ApplicationUser>()
            {
                new ()
                {
                    Id = 1,
                    UserName = "enel@SagRd.Com",
                    NormalizedUserName = "ENEL@SAGRD.COM",
                    Email = "enel@SagRd.Com",
                    NormalizedEmail = "ENEL@SAGRD.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "admin"),
                    SecurityStamp = string.Empty
                },
                new ()
                {
                    Id = 2,
                    UserName = "user@SagRd.Com",
                    NormalizedUserName = "USER@SAGRD.COM",
                    Email = "user@SagRd.Com",
                    NormalizedEmail = "USER@SAGRD.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "user"),
                    SecurityStamp = string.Empty
                },
            });

        //agregar el rol admin a enel
        builder.Entity<IdentityUserRole<int>>().HasData(
            new List<IdentityUserRole<int>>()
            {
                new()
                {
                    RoleId = 1,
                    UserId = 1
                }
            });
    }
}
