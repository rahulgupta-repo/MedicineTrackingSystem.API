using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingSystem.Models
{
    public class Medicine
    {
        public string FullName { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? ExpiryDate { get ; set; }
        public string Notes { get; set; }

    }
}
