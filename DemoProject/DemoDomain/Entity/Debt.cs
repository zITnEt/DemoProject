using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDomain.Entity
{
    public class Debt
    {
        public int Id { get; set; }

        public Lifetime Lifetime { get; set; }

        public double Summ { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order? Order { get; set; }
        
    }
}
