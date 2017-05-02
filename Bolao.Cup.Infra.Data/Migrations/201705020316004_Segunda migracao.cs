namespace Bolao.Cup.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segundamigracao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Campeonato", "sit_campeonato", c => c.String(nullable: false, maxLength: 7, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Campeonato", "sit_campeonato", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
    }
}
