namespace ASpecCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCanUeIfcToFactoryLines : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lines", "CanUseIfc", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lines", "CanUseIfc");
        }
    }
}
