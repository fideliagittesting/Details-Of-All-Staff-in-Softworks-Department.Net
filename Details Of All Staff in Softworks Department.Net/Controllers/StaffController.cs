using Details_Of_All_Staff_in_Softworks_Department.Net.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Details_Of_All_Staff_in_Softworks_Department.Net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public StaffController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpGet]
        [ActionName("GetAllStaffs")]
        [Route("GetAllStaff")]
        public async Task<IActionResult> GetAllStaffs()
        {
            try
            {
                var staffResponse = new StaffUtil(_configuration);
                return Ok(await staffResponse.GetAllStaff());
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet]
        [ActionName("GetAllStaffsAndDateCreated")]
        [Route("GetAllStaffsAndDateCreated")]
        public async Task<IActionResult> GetAllStaffsAndDateCreated()
        {
            try
            {
                var StaffResponseDateCreated = new StaffUtil(_configuration);
                return Ok(await StaffResponseDateCreated.GetAllStaffsAndDateCreated());
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet]
        [ActionName("GetStaffByStaffId")]
        [Route("GetStaffByStaffId")]
        public async Task<IActionResult> GetStaffByStaffId(int staff_id)
        {
            try
            {
                var StaffResponse = new StaffUtil(_configuration);
                return Ok(await StaffResponse.GetAllStaffByStaff_Id(staff_id));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
