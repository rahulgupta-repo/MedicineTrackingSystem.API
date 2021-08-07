using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineTrackingSystem.Models;

namespace MedicineTrackingSystem.Repository
{
    public interface IMedicineRepository
    {
        public List<Medicine> GetAllMedicines();
    }
}
