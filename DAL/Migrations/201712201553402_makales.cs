namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Makales", "YazarID", c => c.Int(nullable: false));
            AddColumn("dbo.Makales", "MakaleBaslik", c => c.String());
            AddColumn("dbo.Makales", "MakaleKonusu", c => c.String());
            AddColumn("dbo.Makales", "YazarAdi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Makales", "YazarAdi");
            DropColumn("dbo.Makales", "MakaleKonusu");
            DropColumn("dbo.Makales", "MakaleBaslik");
            DropColumn("dbo.Makales", "YazarID");
        }
    }
}
