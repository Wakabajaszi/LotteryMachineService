using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotteryMachineService.Entities
{
    public class Adress
    {
        
        public int Id { get; set; }
        public string Street { get; set;}
        public string City { get; set; }
        public string PostalCode { get; set; }


        public virtual Member Member { get; set; }

    }
}
