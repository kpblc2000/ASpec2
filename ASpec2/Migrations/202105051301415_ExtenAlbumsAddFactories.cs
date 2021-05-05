namespace ASpec2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtenAlbumsAddFactories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Albums", "ShortName", c => c.String());
            AddColumn("dbo.Albums", "CreateYear", c => c.Int(nullable: false));
            AddColumn("dbo.Albums", "IsActual", c => c.Boolean(nullable: false));
            AddColumn("dbo.Albums", "SheetRange", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "SheetRange");
            DropColumn("dbo.Albums", "IsActual");
            DropColumn("dbo.Albums", "CreateYear");
            DropColumn("dbo.Albums", "ShortName");
            DropTable("dbo.Factories");
        }
    }
}
