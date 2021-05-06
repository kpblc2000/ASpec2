namespace ASpec2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Factory_Id", c => c.Int());
            CreateIndex("dbo.Albums", "Factory_Id");
            AddForeignKey("dbo.Albums", "Factory_Id", "dbo.Factories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "Factory_Id", "dbo.Factories");
            DropIndex("dbo.Albums", new[] { "Factory_Id" });
            DropColumn("dbo.Albums", "Factory_Id");
        }
    }
}
