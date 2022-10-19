using Business.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {

        IAdminService _adminService;

        public AdminsController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("getById")]
        public IActionResult Get(int id)
        {
            var result = _adminService.Get(id);
            return
                result.Success == true ?
                Ok(result) : 
                BadRequest(result);
        }

        [HttpGet("entryControl")]
        public IActionResult EntryControl(string username, string password)
        {
            var result = _adminService.EntryControl(username, password);
            return
                result.Success == true ?
                Ok(result) :
                BadRequest(result);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _adminService.GetAll();
            return
                result.Success == true ?
                Ok(result) :
                BadRequest(result);
        }
    }
}
