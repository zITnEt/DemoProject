using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDomain.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public double TotalSumm { get; set; }

        public int DebtId { get; set; }

        public int CustomerId { get; set; }
        public User? Customer { get; set; }

        public DateTime CreateDate { get; set; }

        public int ProductStoreId { get; set; }
        public ProductStore? ProductStore { get; set; }
    }
}
