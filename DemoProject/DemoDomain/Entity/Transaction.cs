using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDomain.Entity
{
    public class Transaction
    {
        public int Id { get; set; }

        public int ProductStoreId { get; set; }
        public ProductStore? ProductStore { get; set; }

        public double Summ { get; set; }

        public int CustomerId { get; set; }
        public User? Customer { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
