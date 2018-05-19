namespace Furniture_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Furnitures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weight = c.String(nullable: false),
                        FurnitureTypeId = c.Int(nullable: false),
                        HomeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FurnitureTypes", t => t.FurnitureTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Homes", t => t.HomeId, cascadeDelete: true)
                .Index(t => t.FurnitureTypeId)
                .Index(t => t.HomeId);
            
            CreateTable(
                "dbo.FurnitureTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Homes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Furnitures", "HomeId", "dbo.Homes");
            DropForeignKey("dbo.Furnitures", "FurnitureTypeId", "dbo.FurnitureTypes");
            DropIndex("dbo.Furnitures", new[] { "HomeId" });
            DropIndex("dbo.Furnitures", new[] { "FurnitureTypeId" });
            DropTable("dbo.Homes");
            DropTable("dbo.FurnitureTypes");
            DropTable("dbo.Furnitures");
        }
    }
}
