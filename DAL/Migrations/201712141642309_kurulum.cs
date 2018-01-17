namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Makales", "Konu_KonuID", "dbo.Konus");
            DropForeignKey("dbo.VideoKonus", "Video_VideoID", "dbo.Videos");
            DropForeignKey("dbo.VideoKonus", "Konu_KonuID", "dbo.Konus");
            DropForeignKey("dbo.Konus", "UstKonuID", "dbo.Konus");
            DropIndex("dbo.Konus", new[] { "UstKonuID" });
            DropIndex("dbo.Makales", new[] { "Konu_KonuID" });
            DropIndex("dbo.VideoKonus", new[] { "Video_VideoID" });
            DropIndex("dbo.VideoKonus", new[] { "Konu_KonuID" });
            DropColumn("dbo.Makales", "Konu_KonuID");
            DropTable("dbo.Konus");
            DropTable("dbo.Videos");
            DropTable("dbo.VideoKonus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VideoKonus",
                c => new
                    {
                        Video_VideoID = c.Int(nullable: false),
                        Konu_KonuID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_VideoID, t.Konu_KonuID });
            
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
                "dbo.Konus",
                c => new
                    {
                        KonuID = c.Int(nullable: false, identity: true),
                        KonuBaslik = c.String(nullable: false, maxLength: 100),
                        KonuIcerik = c.String(nullable: false),
                        UstKonuID = c.Int(),
                    })
                .PrimaryKey(t => t.KonuID);
            
            AddColumn("dbo.Makales", "Konu_KonuID", c => c.Int());
            CreateIndex("dbo.VideoKonus", "Konu_KonuID");
            CreateIndex("dbo.VideoKonus", "Video_VideoID");
            CreateIndex("dbo.Makales", "Konu_KonuID");
            CreateIndex("dbo.Konus", "UstKonuID");
            AddForeignKey("dbo.Konus", "UstKonuID", "dbo.Konus", "KonuID");
            AddForeignKey("dbo.VideoKonus", "Konu_KonuID", "dbo.Konus", "KonuID", cascadeDelete: true);
            AddForeignKey("dbo.VideoKonus", "Video_VideoID", "dbo.Videos", "VideoID", cascadeDelete: true);
            AddForeignKey("dbo.Makales", "Konu_KonuID", "dbo.Konus", "KonuID");
        }
    }
}
