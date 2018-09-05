namespace BookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "author");
            DropColumn("dbo.Books", "review");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "review", c => c.String());
            AddColumn("dbo.Books", "author", c => c.String());
        }
    }
}
