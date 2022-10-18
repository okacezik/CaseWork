using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("getById")]
        public IActionResult GetPatient(int id)
        {
            var result = _patientService.GetById(id);
            return
                result.Success == true ?
                Ok(result) :
                BadRequest(result);
        }

        [HttpGet("getByIdentityNumber")]
        public IActionResult GetByIdentityNumber(string identityNumber)
        {
            var result = _patientService.GetByIdentityNumber(identityNumber);
            return
                result.Success == true ?
                Ok(result) :
                BadRequest(result);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _patientService.GetAll();
            return
                result.Success == true ?
                Ok(result) :
                BadRequest("sistem isteğe yanıt veremedi...");
        }

        [HttpGet("getAllPatientsDetails")]
        public IActionResult GetAllPatientsDetails()
        {
            var result = _patientService.GetAllPatientsDetails();
            return
                result.Success == true ?
                Ok(result) :
                BadRequest(result);
        }

        [HttpGet("getAllPositivePatients")]
        public IActionResult GetAllPositivePatients()
        {
            var result = _patientService.GetAllPositive();
            return
                result.Success == true ?
                Ok(result) :
                BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddPatient(Patient patient)
        {
            var result = _patientService.Add(patient);
            return
                result.Success == true ?
                Ok(result) :
                BadRequest("Hasta sisteme eklenemedi...");
        }

        [HttpDelete("delete")]
        public IActionResult DeletePatient(string identityNumber)
        {
            var result = _patientService.Delete(identityNumber);
            return
                result.Success == true ?
                Ok(result) :
                BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult UpdatedPatient(Patient patient)
        {
            var result = _patientService.Update(patient);
            return
                result.Success == true ?
                Ok(result) :
                BadRequest(result);
        }
    }
}
