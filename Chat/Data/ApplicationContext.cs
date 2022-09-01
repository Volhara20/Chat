using Chat.Models.DboModels;
using Microsoft.EntityFrameworkCore;

namespace Chat.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureUsersTable(modelBuilder);
            ConfigureGroupsTable(modelBuilder);

            DataSeed(modelBuilder);
        }

        private void DataSeed(ModelBuilder modelBuilder)
        {
            AddUsers(modelBuilder);
            AddGroups(modelBuilder);
        }

        private void ConfigureUsersTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
           .Property(u => u.Created)
           .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<User>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

        }

        private void ConfigureGroupsTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
            .Property(u => u.Created)
            .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Group>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        }

        private void AddGroups(ModelBuilder modelBuilder)
        {
            List<Group> groups = new List<Group>
            {
                new Group
                {
                    Id=Guid.Parse("33E26927-34E7-412B-9D11-B0F93A533BB6"),
                    GroupName="TestGroup1",
                    Created=new DateTime(2022,9,1,17,47,50),
                    Updated=null
                },
                new Group
                {
                    Id=Guid.Parse("56775EE9-6735-485E-9283-C9AB65831C64"),
                    GroupName="TestGroup2",
                    Created= new DateTime(2022,9,1,17,48,50),
                    Updated=null
                }
            };
            modelBuilder.Entity<Group>().HasData(groups);
        }

        private void AddUsers(ModelBuilder modelBuilder)
        {
            List<User> users = new List<User>
            {
                new User
                {
                    Id=Guid.Parse("7AAAB85F-FD13-4EA3-BDA6-6397100AE230"),
                    UserName="olka",
                    Created=new DateTime(2022,9,1,17,45,50),
                    Updated=null
                },
                new User
                {
                    Id=Guid.Parse("D0845B19-DD1F-4459-9890-47E341E5FD15"),
                    UserName="test",
                    Created=new DateTime(2022,9,1,17,46,50),
                    Updated=null
                }
            };

            modelBuilder.Entity<User>().HasData(users);
        }


    }
}
