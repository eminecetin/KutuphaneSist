namespace KutuphaneYonetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBKutuphaneYonetimiAddAbstract : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PremiumKullanicilar",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KullaniciId)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciId)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.StandartKullanicilar",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KullaniciId)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciId)
                .Index(t => t.KullaniciId);
            
            DropColumn("dbo.Kullanicis", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kullanicis", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.StandartKullanicilar", "KullaniciId", "dbo.Kullanicis");
            DropForeignKey("dbo.PremiumKullanicilar", "KullaniciId", "dbo.Kullanicis");
            DropIndex("dbo.StandartKullanicilar", new[] { "KullaniciId" });
            DropIndex("dbo.PremiumKullanicilar", new[] { "KullaniciId" });
            DropTable("dbo.StandartKullanicilar");
            DropTable("dbo.PremiumKullanicilar");
        }
    }
}
