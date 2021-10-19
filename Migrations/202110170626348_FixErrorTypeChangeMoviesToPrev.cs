namespace Video_Store_Web_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixErrorTypeChangeMoviesToPrev : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(maxLength: 255));
        }
    }
}
