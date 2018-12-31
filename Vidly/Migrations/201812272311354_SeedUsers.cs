namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9cca9fea-fc64-4b43-a00e-31e218cb9c73', N'guest@vidly.com', 0, N'AEZWwtTG4taLF6EDt2Rml9m1jJO2uiimSaZYt8NA67TkHkMg6Aft4o4l2RLizecQvg==', N'dd8b11df-3095-4124-9790-423d314ad78f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'afd23c99-1d88-4a8d-8c7f-d1116bcb9b8c', N'admin@vidly.com', 0, N'ADYb4RY1jYLF7j12dCI5a6gWjn8kvp65V1RTfaRbNHnCQ67NF8cY6mPx1HPRxvMB7w==', N'c93d9ec7-bb55-4f70-be4c-6136123d8105', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e5c7160e-56aa-45ed-9087-9b6b817880e1', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'afd23c99-1d88-4a8d-8c7f-d1116bcb9b8c', N'e5c7160e-56aa-45ed-9087-9b6b817880e1')
");
        }
        
        public override void Down()
        {
        }
    }
}
