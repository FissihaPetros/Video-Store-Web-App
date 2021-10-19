namespace Video_Store_Web_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomersBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
