namespace XGame.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlataformMap : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Plataforms", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Plataforms", "Name", c => c.String(maxLength: 100, unicode: false));
        }
    }
}
