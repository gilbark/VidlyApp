namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4618ec12-befd-4636-952c-c2dec51ee997', N'admin@vidly.com', 0, N'AIY8CdvphdtIKYIgZyswG83RjY7EZ5RFr84yP3530OyNCF4+LGqEyeHbcpbtJF1rhA==', N'4b749f08-58a5-4847-ad7b-ae47d68bf9fe', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5fe40a99-9d84-4328-9e12-5bf9d8579b32', N'guest@vidly.com', 0, N'AHrpghtfB7Y8eeeksBNJDm4mE3bn1c79rQmUvoDY6IaBtt+YbZswPy7qsPR9m6M8Yw==', N'ba53bb8d-8b46-4f08-8317-78801dc213bc', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'24cef0cc-7074-4485-9fc8-492e494623d0', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4618ec12-befd-4636-952c-c2dec51ee997', N'24cef0cc-7074-4485-9fc8-492e494623d0')
");
        }

        public override void Down()
        {
        }
    }
}
