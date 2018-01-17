namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum : DbMigration
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
                "dbo.Makales",
                c => new
                    {
                        MakaleID = c.Int(nullable: false, identity: true),
                        MakaleIcerik = c.String(),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        Konu_KonuID = c.Int(),
                    })
                .PrimaryKey(t => t.MakaleID)
                .ForeignKey("dbo.Konus", t => t.Konu_KonuID)
                .Index(t => t.Konu_KonuID);
            
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
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        AdSoyad = c.String(),
                        Meslek = c.String(),
                        WebSitesi = c.String(),
                        DogumTarihi = c.DateTime(),
                        Resim = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        DescriptionGallery = c.String(),
                    })
                .PrimaryKey(t => t.ImageID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Konus", "UstKonuID", "dbo.Konus");
            DropForeignKey("dbo.VideoKonus", "Konu_KonuID", "dbo.Konus");
            DropForeignKey("dbo.VideoKonus", "Video_VideoID", "dbo.Videos");
            DropForeignKey("dbo.Makales", "Konu_KonuID", "dbo.Konus");
            DropIndex("dbo.VideoKonus", new[] { "Konu_KonuID" });
            DropIndex("dbo.VideoKonus", new[] { "Video_VideoID" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Makales", new[] { "Konu_KonuID" });
            DropIndex("dbo.Konus", new[] { "UstKonuID" });
            DropTable("dbo.VideoKonus");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Galleries");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Videos");
            DropTable("dbo.Makales");
            DropTable("dbo.Konus");
        }
    }
}
