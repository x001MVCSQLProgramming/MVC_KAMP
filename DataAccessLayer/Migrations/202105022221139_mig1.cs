namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contents", "author_ID", "dbo.Authors");
            DropIndex("dbo.Contents", new[] { "author_ID" });
            AddColumn("dbo.Headings", "author_ID", c => c.Int());
            AlterColumn("dbo.Contents", "author_ID", c => c.Int());
            CreateIndex("dbo.Contents", "author_ID");
            CreateIndex("dbo.Headings", "author_ID");
            AddForeignKey("dbo.Headings", "author_ID", "dbo.Authors", "author_ID");
            AddForeignKey("dbo.Contents", "author_ID", "dbo.Authors", "author_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "author_ID", "dbo.Authors");
            DropForeignKey("dbo.Headings", "author_ID", "dbo.Authors");
            DropIndex("dbo.Headings", new[] { "author_ID" });
            DropIndex("dbo.Contents", new[] { "author_ID" });
            AlterColumn("dbo.Contents", "author_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Headings", "author_ID");
            CreateIndex("dbo.Contents", "author_ID");
            AddForeignKey("dbo.Contents", "author_ID", "dbo.Authors", "author_ID", cascadeDelete: true);
        }
    }
}
