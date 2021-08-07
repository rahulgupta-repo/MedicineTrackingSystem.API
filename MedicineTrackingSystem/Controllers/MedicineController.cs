using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineTrackingSystem.Models;
using MedicineTrackingSystem.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedicineTrackingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly ILogger<MedicineController> _logger;
        private readonly IMedicineRepository _medicineRepository;

        public MedicineController(ILogger<MedicineController> logger, IMedicineRepository medicineRepository)
        {
            _logger = logger;
            _medicineRepository = medicineRepository;
        }


        // GET: api/<MedicineController>
        [HttpGet]
        public ActionResult<List<Medicine>> Get( )
        {
            List<Medicine> medicines=_medicineRepository.GetAllMedicines();
            return medicines;
        }

        // GET api/<MedicineController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MedicineController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MedicineController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MedicineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
