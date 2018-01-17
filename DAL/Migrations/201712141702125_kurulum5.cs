namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Makales", "ResimURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Makales", "ResimURL");
        }
    }
}
