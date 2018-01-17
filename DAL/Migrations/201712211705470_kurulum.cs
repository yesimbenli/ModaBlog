namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Makales", "Konu_KonuID", "dbo.Konus");
            DropIndex("dbo.Makales", new[] { "Konu_KonuID" });
            CreateTable(
                "dbo.MakaleKonus",
                c => new
                    {
                        Makale_MakaleID = c.Int(nullable: false),
                        Konu_KonuID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Makale_MakaleID, t.Konu_KonuID })
                .ForeignKey("dbo.Makales", t => t.Makale_MakaleID, cascadeDelete: true)
                .ForeignKey("dbo.Konus", t => t.Konu_KonuID, cascadeDelete: true)
                .Index(t => t.Makale_MakaleID)
                .Index(t => t.Konu_KonuID);
            
            AddColumn("dbo.Makales", "Baslik", c => c.String());
            AddColumn("dbo.Makales", "KisaAciklama", c => c.String());
            AddColumn("dbo.Makales", "Content", c => c.String());
            AddColumn("dbo.Makales", "Title", c => c.String());
            AddColumn("dbo.Makales", "Description", c => c.String());
            AddColumn("dbo.Makales", "Keywords", c => c.String());
            AddColumn("dbo.Videos", "Content", c => c.String());
            DropColumn("dbo.Makales", "YazarID");
            DropColumn("dbo.Makales", "Konu_KonuID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Makales", "Konu_KonuID", c => c.Int());
            AddColumn("dbo.Makales", "YazarID", c => c.Int(nullable: false));
            DropForeignKey("dbo.MakaleKonus", "Konu_KonuID", "dbo.Konus");
            DropForeignKey("dbo.MakaleKonus", "Makale_MakaleID", "dbo.Makales");
            DropIndex("dbo.MakaleKonus", new[] { "Konu_KonuID" });
            DropIndex("dbo.MakaleKonus", new[] { "Makale_MakaleID" });
            DropColumn("dbo.Videos", "Content");
            DropColumn("dbo.Makales", "Keywords");
            DropColumn("dbo.Makales", "Description");
            DropColumn("dbo.Makales", "Title");
            DropColumn("dbo.Makales", "Content");
            DropColumn("dbo.Makales", "KisaAciklama");
            DropColumn("dbo.Makales", "Baslik");
            DropTable("dbo.MakaleKonus");
            CreateIndex("dbo.Makales", "Konu_KonuID");
            AddForeignKey("dbo.Makales", "Konu_KonuID", "dbo.Konus", "KonuID");
        }
    }
}
