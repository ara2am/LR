namespace LR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneToOne : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CafeInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Licence = c.Int(nullable: false),
                        Work = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cafes", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CafeInfoes", "Id", "dbo.Cafes");
            DropIndex("dbo.CafeInfoes", new[] { "Id" });
            DropTable("dbo.CafeInfoes");
        }
    }
}
