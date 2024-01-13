namespace KutuphaneYonetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbMigrationKutuphaneYonetimi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Yonetmen = c.String(),
                        YayinYili = c.DateTime(nullable: false),
                        Tur = c.String(),
                        Puan = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.FilmId);
            
            CreateTable(
                "dbo.Yorums",
                c => new
                    {
                        YorumId = c.Int(nullable: false, identity: true),
                        Icerik = c.String(),
                        YorumTarihi = c.DateTime(nullable: false),
                        FilmId = c.Int(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.YorumId)
                .ForeignKey("dbo.Films", t => t.FilmId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.FilmId)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        TC = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        Cinsiyet = c.String(),
                        UyelikTuru = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Yoneticis",
                c => new
                    {
                        YoneticiId = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.YoneticiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorums", "KullaniciId", "dbo.Kullanicis");
            DropForeignKey("dbo.Yorums", "FilmId", "dbo.Films");
            DropIndex("dbo.Yorums", new[] { "KullaniciId" });
            DropIndex("dbo.Yorums", new[] { "FilmId" });
            DropTable("dbo.Yoneticis");
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Yorums");
            DropTable("dbo.Films");
        }
    }
}
