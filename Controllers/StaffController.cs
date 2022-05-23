using CRUDWebAPI.Model;
using CRUDWebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : Controller
    {

         IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService; 
        }


        [HttpGet]
        [Route("GetStaffList")]
      // [Route("[action]")]
        public IActionResult GetStaffList()
        {
           try
            {
                var staff = _staffService.GetStaffList();
                if (staff == null)
                    return NotFound();
                return Ok(staff);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        [Route("SaveStaff")]
       // [Route("[action]")]
        public IActionResult SaveStaff(Staff staffModel)
        {

            ResponseModel response = new ResponseModel();
            try
            {
              var staff=  _staffService.SaveStaff(staffModel);  
              return Ok(staff);
            }
            catch (Exception ex)
            {
                response.IsSucess = false;
                response.Message = ex.Message;
                return Ok(response);        
            }
        }


        [HttpGet]
        [Route("GetStaffDetailsByID/{StaffID}")]
        // [Route("[action/StaffID]")]
        public IActionResult GetStaffDetailsByID(int StaffID)
        {
            try
            {
                var staff = _staffService.GetStaffDetailsByID(StaffID);
                if (staff == null)
                    return NotFound();
                return Ok(staff);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("DeleteStaff/{StaffId}")]
        //  [Route("[action/StaffID]")]
        public IActionResult DeleteStaff(int StaffId)
        {
            try
            {
                var staff = _staffService.DeleteStaff(StaffId);             
                return Ok(staff);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
