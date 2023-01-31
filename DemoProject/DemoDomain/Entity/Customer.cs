using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDomain.Entity
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DebtId { get; set; }
        public Debt Debt { get; set; }

        public double Balance { get; set; }
    }