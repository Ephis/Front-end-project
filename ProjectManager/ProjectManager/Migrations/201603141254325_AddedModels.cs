namespace ProjectManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        pictureUrl = c.String(),
                        createdAt = c.DateTime(nullable: false),
                        creator_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.creator_id)
                .Index(t => t.creator_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Project_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Projects", t => t.Project_id)
                .Index(t => t.Project_id);
            
            CreateTable(
                "dbo.Sprints",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Project_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Projects", t => t.Project_id)
                .Index(t => t.Project_id);
            
            CreateTable(
                "dbo.Stories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        estimat = c.Int(nullable: false),
                        priority = c.Int(nullable: false),
                        isDone = c.Boolean(nullable: false),
                        actualTime = c.Int(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        creator_id = c.Int(),
                        project_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.creator_id)
                .ForeignKey("dbo.Projects", t => t.project_id)
                .Index(t => t.creator_id)
                .Index(t => t.project_id);
            
            AddColumn("dbo.Taskmodels", "name", c => c.String());
            AddColumn("dbo.Taskmodels", "description", c => c.String());
            AddColumn("dbo.Taskmodels", "status", c => c.Int(nullable: false));
            AddColumn("dbo.Taskmodels", "createdAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Taskmodels", "responseable_id", c => c.Int());
            AddColumn("dbo.Taskmodels", "story_id", c => c.Int());
            CreateIndex("dbo.Taskmodels", "responseable_id");
            CreateIndex("dbo.Taskmodels", "story_id");
            AddForeignKey("dbo.Taskmodels", "responseable_id", "dbo.Users", "id");
            AddForeignKey("dbo.Taskmodels", "story_id", "dbo.Stories", "id");
            DropColumn("dbo.Taskmodels", "tiltle");
            DropColumn("dbo.Taskmodels", "owner");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Taskmodels", "owner", c => c.Int(nullable: false));
            AddColumn("dbo.Taskmodels", "tiltle", c => c.String());
            DropForeignKey("dbo.Taskmodels", "story_id", "dbo.Stories");
            DropForeignKey("dbo.Taskmodels", "responseable_id", "dbo.Users");
            DropForeignKey("dbo.Stories", "project_id", "dbo.Projects");
            DropForeignKey("dbo.Stories", "creator_id", "dbo.Users");
            DropForeignKey("dbo.Sprints", "Project_id", "dbo.Projects");
            DropForeignKey("dbo.Users", "Project_id", "dbo.Projects");
            DropForeignKey("dbo.Projects", "creator_id", "dbo.Users");
            DropIndex("dbo.Taskmodels", new[] { "story_id" });
            DropIndex("dbo.Taskmodels", new[] { "responseable_id" });
            DropIndex("dbo.Stories", new[] { "project_id" });
            DropIndex("dbo.Stories", new[] { "creator_id" });
            DropIndex("dbo.Sprints", new[] { "Project_id" });
            DropIndex("dbo.Users", new[] { "Project_id" });
            DropIndex("dbo.Projects", new[] { "creator_id" });
            DropColumn("dbo.Taskmodels", "story_id");
            DropColumn("dbo.Taskmodels", "responseable_id");
            DropColumn("dbo.Taskmodels", "createdAt");
            DropColumn("dbo.Taskmodels", "status");
            DropColumn("dbo.Taskmodels", "description");
            DropColumn("dbo.Taskmodels", "name");
            DropTable("dbo.Stories");
            DropTable("dbo.Sprints");
            DropTable("dbo.Users");
            DropTable("dbo.Projects");
        }
    }
}
