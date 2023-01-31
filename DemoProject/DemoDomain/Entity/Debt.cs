using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDomain.Entity
{
    public class Debt
    {
        public int Id { get; set; }

        public int LifeTime { get; set; }

        public double Summ { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
