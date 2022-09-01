using Chat.Models.DboModels;
using Microsoft.EntityFrameworkCore;

namespace Chat.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Message> Messages { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureUsersTable(modelBuilder);
            ConfigureGroupsTable(modelBuilder);
            ConfigureMessagesTable(modelBuilder);

            modelBuilder.Entity<User>()
               .HasMany(c => c.Groups)
               .WithMany(s => s.Users)
               .UsingEntity(j =>
               {
                   j.ToTable("UserGroupsRelationship").HasData(new[]
                   {
                        new {
                                UsersId=Guid.Parse("7AAAB85F-FD13-4EA3-BDA6-6397100AE230"),
                                GroupsId=Guid.Parse("33E26927-34E7-412B-9D11-B0F93A533BB6")
                            },
                        new {
                                UsersId=Guid.Parse("7AAAB85F-FD13-4EA3-BDA6-6397100AE230"),
                                GroupsId=Guid.Parse("56775EE9-6735-485E-9283-C9AB65831C64")
                            },
                        new {
                                UsersId=Guid.Parse("D0845B19-DD1F-4459-9890-47E341E5FD15"),
                                GroupsId=Guid.Parse("33E26927-34E7-412B-9D11-B0F93A533BB6")
                            },
                   });
               });

            DataSeed(modelBuilder);
        }

        private void DataSeed(ModelBuilder modelBuilder)
        {
            AddUsers(modelBuilder);
            AddGroups(modelBuilder);
            AddMessages(modelBuilder);
        }

        private void ConfigureMessagesTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .Property(u => u.Created)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Message>()
                .Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");
        }

        private void ConfigureUsersTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Created)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<User>()
                .Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");

        }

        private void ConfigureGroupsTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .Property(u => u.Created)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Group>()
                .Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");
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

        private void AddMessages(ModelBuilder modelBuilder)
        {
            List<Message> messages = new List<Message>
            {
                new Message
                {
                    Id=Guid.Parse("9f822d7d-dd51-40be-af82-115916947844"),
                    Text="Hello",
                    FromUserId=Guid.Parse("7AAAB85F-FD13-4EA3-BDA6-6397100AE230"),
                    ToUserId= Guid.Parse("D0845B19-DD1F-4459-9890-47E341E5FD15"),
                    GroupId=null,
                    IsVisible=true,
                    IsVisibleForOwner=true,
                    ReplyMessageId=null,
                    Created=new DateTime(2022,9,1,17,55,50),
                    Updated=null
                },
                new Message
                {
                    Id=Guid.Parse("5d045d62-5364-4aa1-b12a-2eab889d6a77"),
                    Text="Hi",
                    FromUserId=Guid.Parse("D0845B19-DD1F-4459-9890-47E341E5FD15"),
                    ToUserId= Guid.Parse("7AAAB85F-FD13-4EA3-BDA6-6397100AE230"),
                    GroupId=null,
                    IsVisible=true,
                    IsVisibleForOwner=true,
                    ReplyMessageId=null,
                    Created=new DateTime(2022,9,1,17,56,50),
                    Updated=null
                },
                new Message
                {
                    Id=Guid.Parse("7f00d977-9b3a-4780-896d-1fb4d3d6ecae"),
                    Text="How are you?",
                    FromUserId=Guid.Parse("7AAAB85F-FD13-4EA3-BDA6-6397100AE230"),
                    ToUserId= Guid.Parse("D0845B19-DD1F-4459-9890-47E341E5FD15"),
                    GroupId=null,
                    IsVisible=true,
                    IsVisibleForOwner=true,
                    ReplyMessageId=Guid.Parse("5d045d62-5364-4aa1-b12a-2eab889d6a77"),
                    Created=new DateTime(2022,9,1,17,57,50),
                    Updated=null
                },
                new Message
                {
                    Id=Guid.Parse("d59b98a3-2fc7-48af-a483-07b6f0d45c6c"),
                    Text="Lol",
                    FromUserId=Guid.Parse("D0845B19-DD1F-4459-9890-47E341E5FD15"),
                    ToUserId=null,
                    GroupId=Guid.Parse("33E26927-34E7-412B-9D11-B0F93A533BB6"),
                    IsVisible=true,
                    IsVisibleForOwner=true,
                    ReplyMessageId=null,
                    Created=new DateTime(2022,9,1,17,56,50),
                    Updated=null
                },
                new Message
                {
                    Id=Guid.Parse("315a053f-f19a-4a5d-9022-e6190400c006"),
                    Text="Kek",
                    FromUserId=Guid.Parse("7AAAB85F-FD13-4EA3-BDA6-6397100AE230"),
                    ToUserId=null,
                    GroupId=Guid.Parse("33E26927-34E7-412B-9D11-B0F93A533BB6"),
                    IsVisible=true,
                    IsVisibleForOwner=true,
                    ReplyMessageId=null,
                    Created=new DateTime(2022,9,1,17,57,50),
                    Updated=null
                },
            };

            modelBuilder.Entity<Message>().HasData(messages);
        }
    }
}
