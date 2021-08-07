using MedicineTrackingSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingSystem.Repository
{
    public class MedicineRepository : IMedicineRepository
    {

        public List<Medicine> GetAllMedicines()
        {
            string jsonData = File.ReadAllText("Medicine.json");
            List<Medicine> medicineList = JsonConvert.DeserializeObject<List<Medicine>>(jsonData);
            return medicineList;
        }
    }
}
