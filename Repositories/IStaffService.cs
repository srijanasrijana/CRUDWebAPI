using CRUDWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebAPI.Repositories
{
   public interface IStaffService 
    {
        ResponseModel  GetStaffList();
        ResponseModel GetStaffDetailsByID(int StaffId);
        ResponseModel SaveStaff(Staff staffmodel);
        ResponseModel DeleteStaff(int StaffID);


    }

}
