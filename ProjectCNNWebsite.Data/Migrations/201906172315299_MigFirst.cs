namespace ProjectCNNWebsite.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminId = c.Int(nullable: false),
                        AdminFirstName = c.String(),
                        AdminLastName = c.String(),
                        AdminDateOfBirth = c.DateTime(),
                        AdminEmailAddress = c.String(),
                        AdminNickName = c.String(),
                        AdminPassword = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        TimeOfCreation = c.DateTime(),
                        TimeOfModification = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryDescription = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        TimeOfCreation = c.DateTime(),
                        TimeOfModification = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NewsTitle = c.String(),
                        NewsContent = c.String(),
                        NewsPhotoPath = c.String(),
                        CategoryId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        TimeOfCreation = c.DateTime(),
                        TimeOfModification = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "CategoryId", "dbo.Category");
            DropIndex("dbo.News", new[] { "CategoryId" });
            DropTable("dbo.News");
            DropTable("dbo.Category");
            DropTable("dbo.Admin");
        }
    }
}
