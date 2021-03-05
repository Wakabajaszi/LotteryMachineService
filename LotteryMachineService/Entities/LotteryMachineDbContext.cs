using LotteryMachineService.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LotteryMachineService
{
    public class LotteryMachineDbContext : DbContext
    {
       
        public LotteryMachineDbContext()
            : base("name=LotteryMachineDbContext")
        {
            //Database.SetInitializer(new DbInitializer());
        }


        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Adress> Adresses { get; set; }
        //public virtual DbSet<Sex> Sex { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                 .HasOptional(a => a.Adress)
                 .WithRequired(ab => ab.Member)
                 .WillCascadeOnDelete(true);
            modelBuilder.Entity<Member>()
                .HasRequired<Sex>(s => s.Sex)
                .WithMany(g => g.Member)
                .HasForeignKey<int?>(s => s.SexId);
        }
       
    }

    
}