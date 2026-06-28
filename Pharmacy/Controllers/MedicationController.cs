using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicationController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Medication>> Get()
        {
            return Ok(MedicationData.GetMedications());
        }

        [HttpGet("{id}")]
        public ActionResult<Medication> GetById(int id)
        {
            var medication = MedicationData.GetMedications().FirstOrDefault(m => m.Id == id);
            if (medication == null)
            {
                return NotFound();
            }
            return Ok(medication);
        }
    }
}