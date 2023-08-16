namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "DateOfRegister", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "AllowDays", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "AllowDays", c => c.String());
            DropColumn("dbo.AspNetUsers", "DateOfRegister");
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
        }
    }
}
