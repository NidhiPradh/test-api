using iFlow_crud.repository.Models;
using iFlow_crud.service.FlowService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//Test for git
namespace iFlow_crud.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IFlowService flowService;

        public PatientController(IFlowService _flowService)
        {
            flowService = _flowService;
        }
        [HttpPost("AddPatient")]
        public async Task<IActionResult> AddPatient(Patient patient) 
        {
            await flowService.AddAsync(patient);

            // Success response
            return Ok(new { success = true, message = "Patient added successfully.", data = patient });
        }
        //public async Task<IActionResult> Add(Patient patient)
        //{
        //    FirstName = patient.FirstName;
        //    return patient;
        //}


    }
}
