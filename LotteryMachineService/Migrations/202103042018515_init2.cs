namespace LotteryMachineService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "SexId", c => c.Int(nullable: false));
            CreateIndex("dbo.Members", "SexId");
            AddForeignKey("dbo.Members", "SexId", "dbo.Sexes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "SexId", "dbo.Sexes");
            DropIndex("dbo.Members", new[] { "SexId" });
            DropColumn("dbo.Members", "SexId");
            DropTable("dbo.Sexes");
        }
    }
}
