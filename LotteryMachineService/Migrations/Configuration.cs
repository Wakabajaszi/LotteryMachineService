namespace LotteryMachineService.Migrations
{
    using LotteryMachineService.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LotteryMachineService.LotteryMachineDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LotteryMachineService.LotteryMachineDbContext context)
        {
           
        }
    }
}
