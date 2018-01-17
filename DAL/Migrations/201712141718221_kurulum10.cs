namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Makales", "Baslik", c => c.String());
            AddColumn("dbo.Makales", "KisaAciklama", c => c.String());
            AddColumn("dbo.Makales", "Title", c => c.String());
            AddColumn("dbo.Makales", "Description", c => c.String());
            AddColumn("dbo.Makales", "Keywords", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Makales", "Keywords");
            DropColumn("dbo.Makales", "Description");
            DropColumn("dbo.Makales", "Title");
            DropColumn("dbo.Makales", "KisaAciklama");
            DropColumn("dbo.Makales", "Baslik");
        }
    }
}
