namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MakaleKonus", "Makale_MakaleID", "dbo.Makales");
            DropForeignKey("dbo.MakaleKonus", "Konu_KonuID", "dbo.Konus");
            DropForeignKey("dbo.VideoKonus", "Video_VideoID", "dbo.Videos");
            DropForeignKey("dbo.VideoKonus", "Konu_KonuID", "dbo.Konus");
            DropForeignKey("dbo.Konus", "UstKonuID", "dbo.Konus");
            DropIndex("dbo.Konus", new[] { "UstKonuID" });
            DropIndex("dbo.MakaleKonus", new[] { "Makale_MakaleID" });
            DropIndex("dbo.MakaleKonus", new[] { "Konu_KonuID" });
            DropIndex("dbo.VideoKonus", new[] { "Video_VideoID" });
            DropIndex("dbo.VideoKonus", new[] { "Konu_KonuID" });
            DropTable("dbo.Konus");
            DropTable("dbo.MakaleKonus");
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
                "dbo.MakaleKonus",
                c => new
                    {
                        Makale_MakaleID = c.Int(nullable: false),
                        Konu_KonuID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Makale_MakaleID, t.Konu_KonuID });
            
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
            
            CreateIndex("dbo.VideoKonus", "Konu_KonuID");
            CreateIndex("dbo.VideoKonus", "Video_VideoID");
            CreateIndex("dbo.MakaleKonus", "Konu_KonuID");
            CreateIndex("dbo.MakaleKonus", "Makale_MakaleID");
            CreateIndex("dbo.Konus", "UstKonuID");
            AddForeignKey("dbo.Konus", "UstKonuID", "dbo.Konus", "KonuID");
            AddForeignKey("dbo.VideoKonus", "Konu_KonuID", "dbo.Konus", "KonuID", cascadeDelete: true);
            AddForeignKey("dbo.VideoKonus", "Video_VideoID", "dbo.Videos", "VideoID", cascadeDelete: true);
            AddForeignKey("dbo.MakaleKonus", "Konu_KonuID", "dbo.Konus", "KonuID", cascadeDelete: true);
            AddForeignKey("dbo.MakaleKonus", "Makale_MakaleID", "dbo.Makales", "MakaleID", cascadeDelete: true);
        }
    }
}
