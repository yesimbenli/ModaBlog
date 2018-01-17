namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Makales", newName: "Iceriks");
            AddColumn("dbo.Iceriks", "Baslik", c => c.String());
            AddColumn("dbo.Iceriks", "KisaAciklama", c => c.String());
            AddColumn("dbo.Iceriks", "Content", c => c.String());
            AddColumn("dbo.Iceriks", "Title", c => c.String());
            AddColumn("dbo.Iceriks", "Description", c => c.String());
            AddColumn("dbo.Iceriks", "Keywords", c => c.String());
            AlterColumn("dbo.Iceriks", "EklenmeTarihi", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Iceriks", "EklenmeTarihi", c => c.DateTime(nullable: false));
            DropColumn("dbo.Iceriks", "Keywords");
            DropColumn("dbo.Iceriks", "Description");
            DropColumn("dbo.Iceriks", "Title");
            DropColumn("dbo.Iceriks", "Content");
            DropColumn("dbo.Iceriks", "KisaAciklama");
            DropColumn("dbo.Iceriks", "Baslik");
            RenameTable(name: "dbo.Iceriks", newName: "Makales");
        }
    }
}
