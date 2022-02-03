using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Entities
{
    public class Context : IdentityDbContext<User, Role, string, IdentityUserClaim<string>,
        UserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Robot> Robots { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>().HasKey(userrole =>
            new { userrole.UserId, userrole.RoleId });

            builder.Entity<UserRole>()
                .HasOne<User>(userrole => userrole.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(userrole => userrole.UserId);

            builder.Entity<UserRole>()
                .HasOne<Role>(userrole => userrole.Role)
                .WithMany(role => role.UserRoles)
                .HasForeignKey(userrole => userrole.RoleId);

            builder.Entity<Crew>().HasKey(crew =>
            new { crew.UserId, crew.RobotId });

            builder.Entity<Crew>()
                .HasOne<User>(crew => crew.User)
                .WithMany(u => u.Crews)
                .HasForeignKey(crew => crew.UserId);

            builder.Entity<Crew>()
                .HasOne<Robot>(crew => crew.Robot)
                .WithMany(robot => robot.Crews)
                .HasForeignKey(crew => crew.RobotId);
        }
    }
}
