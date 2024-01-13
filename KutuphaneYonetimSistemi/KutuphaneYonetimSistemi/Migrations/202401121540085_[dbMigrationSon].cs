namespace KutuphaneYonetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbMigrationSon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kullanicis", "kullaniciAdi", c => c.String());
            AddColumn("dbo.Kullanicis", "sifre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kullanicis", "sifre");
            DropColumn("dbo.Kullanicis", "kullaniciAdi");
        }
    }
}
