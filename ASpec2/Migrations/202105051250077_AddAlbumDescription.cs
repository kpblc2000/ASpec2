namespace ASpec2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAlbumDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Description");
        }
    }
}
