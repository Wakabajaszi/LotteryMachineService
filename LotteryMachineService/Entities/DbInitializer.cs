using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryMachineService.Entities
{
    class DbInitializer: DropCreateDatabaseAlways<LotteryMachineDbContext>
    {
        protected override void Seed(LotteryMachineDbContext context)
        {
            //IList<Sex> sex = new List<Sex>();

            //sex.Add(new Sex() { Name = "Man" });
            //sex.Add(new Sex() { Name = "Woman" });

            //context.Sex.AddRange(sex);
            //base.Seed(context);
        }
    }
}
