namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Konus",
                c => new
                    {
                        KonuID = c.Int(nullable: false, identity: true),
                        KonuBaslik = c.String(nullable: false, maxLength: 100),
                        KonuIcerik = c.String(nullable: false),
                        UstKonuID = c.Int(),
                    })
                .PrimaryKey(t => t.KonuID)
                .ForeignKey("dbo.Konus", t => t.UstKonuID)
                .Index(t => t.UstKonuID);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        VideoID = c.Int(nullable: false, identity: true),
                        VideoURL = c.String(),
                        Aciklama = c.String(nullable: false, maxLength: 100),
                        IzlenmeSayisi = c.Int(nullable: false),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        Baslik = c.String(),
                        KisaAciklama = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Keywords = c.String(),
                    })
                .PrimaryKey(t => t.VideoID);
            
            CreateTable(
                "dbo.VideoKonus",
                c => new
                    {
                        Video_VideoID = c.Int(nullable: false),
                        Konu_KonuID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_VideoID, t.Konu_KonuID })
                .ForeignKey("dbo.Videos", t => t.Video_VideoID, cascadeDelete: true)
                .ForeignKey("dbo.Konus", t => t.Konu_KonuID, cascadeDelete: true)
                .Index(t => t.Video_VideoID)
                .Index(t => t.Konu_KonuID);
            
            AddColumn("dbo.Makales", "Konu_KonuID", c => c.Int());
            CreateIndex("dbo.Makales", "Konu_KonuID");
            AddForeignKey("dbo.Makales", "Konu_KonuID", "dbo.Konus", "KonuID");
            DropColumn("dbo.Makales", "Baslik");
            DropColumn("dbo.Makales", "KisaAciklama");
            DropColumn("dbo.Makales", "Title");
            DropColumn("dbo.Makales", "Description");
            DropColumn("dbo.Makales", "Keywords");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Makales", "Keywords", c => c.String());
            AddColumn("dbo.Makales", "Description", c => c.String());
            AddColumn("dbo.Makales", "Title", c => c.String());
            AddColumn("dbo.Makales", "KisaAciklama", c => c.String());
            AddColumn("dbo.Makales", "Baslik", c => c.String());
            DropForeignKey("dbo.Konus", "UstKonuID", "dbo.Konus");
            DropForeignKey("dbo.VideoKonus", "Konu_KonuID", "dbo.Konus");
            DropForeignKey("dbo.VideoKonus", "Video_VideoID", "dbo.Videos");
            DropForeignKey("dbo.Makales", "Konu_KonuID", "dbo.Konus");
            DropIndex("dbo.VideoKonus", new[] { "Konu_KonuID" });
            DropIndex("dbo.VideoKonus", new[] { "Video_VideoID" });
            DropIndex("dbo.Makales", new[] { "Konu_KonuID" });
            DropIndex("dbo.Konus", new[] { "UstKonuID" });
            DropColumn("dbo.Makales", "Konu_KonuID");
            DropTable("dbo.VideoKonus");
            DropTable("dbo.Videos");
            DropTable("dbo.Konus");
        }
    }
}
