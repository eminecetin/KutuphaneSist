namespace KutuphaneYonetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KutuphaneYonetimi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Oyuncular", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Oyuncular");
        }
    }
}
