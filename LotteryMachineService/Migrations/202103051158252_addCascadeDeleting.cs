namespace LotteryMachineService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCascadeDeleting : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Adresses", "Id", "dbo.Members");
            AddForeignKey("dbo.Adresses", "Id", "dbo.Members", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adresses", "Id", "dbo.Members");
            AddForeignKey("dbo.Adresses", "Id", "dbo.Members", "Id");
        }
    }
}
