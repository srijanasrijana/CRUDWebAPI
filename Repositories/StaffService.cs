using CRUDWebAPI.Config;
using CRUDWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebAPI.Repositories
{
    public class StaffService : IStaffService
    {
        private readonly ApplicationDbContext _DbContext;
        public StaffService(ApplicationDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public ResponseModel GetStaffList()
        {
            ResponseModel response = new ResponseModel();

         //   List<Staff> staffList;
            try
            {
             //   staffList = _DbContext.Set<Staff>().ToList();
                List<Staff> staffList = _DbContext.Set<Staff>().ToList();
                response.ResponseData = staffList; 
            }
            catch (Exception ex)
            {
                throw ex;
            }

           // return staffList;
            return response;
        }

        public ResponseModel GetStaffDetailsByID(int StaffId)
        {

            ResponseModel response = new ResponseModel();
            //Staff staff;
            try
            {
                Staff staff = _DbContext.Find<Staff>(StaffId);

                //List<Staff> stafflIST = _DbContext.Find<Staff>(StaffId);
                response.IsSucess = true;
                response.ResponseData = staff;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //return staff;
            return response;
        }
        public ResponseModel SaveStaff(Staff staffmodel)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                // Staff _tmp = GetStaffDetailsByID(staffmodel.StaffId);
                ResponseModel responseModal = GetStaffDetailsByID(staffmodel.StaffId);
                Staff _tmp = (Staff)responseModal.ResponseData;
                {
                    if (_tmp != null)
                    {
                        _tmp.StaffFirstName = staffmodel.StaffFirstName;
                        _tmp.StaffLastName = staffmodel.StaffLastName;
                        _tmp.Salary = staffmodel.Salary;
                        _tmp.Designation = staffmodel.Designation;
                        _DbContext.Update<Staff>(_tmp);
                        response.Message = "Staff Update Sucessfully";
                     //   response.ResponseData = _tmp;
                       
                    }
                    else
                    {
                        _DbContext.Add<Staff>(staffmodel);
                        response.Message = "Staff Save Sucessfully";
                        //response.ResponseData = _tmp;
                    }
                    _DbContext.SaveChanges();
                    response.IsSucess = true;
                    response.ResponseData = _tmp;

                }
            }
            catch (Exception ex)
            {
                throw ex;
                //response.IsSucess = false;
                //response.Message = "Error:" + ex.Message;
               
            }
            return response;
          
        }
        
        public ResponseModel DeleteStaff(int StaffID)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                ResponseModel responseModel = GetStaffDetailsByID(StaffID);
                Staff _tmp = (Staff)responseModel.ResponseData;
                if(_tmp != null)
                {
                    _DbContext.Remove<Staff>(_tmp);
                    _DbContext.SaveChanges();
                    response.Message = "Delete Suceessfully";
                    response.IsSucess = true;
                    response.ResponseData = _tmp;
                }
                else
                {
                    response.Message = "Satff  Not Found";
                    response.IsSucess = false;
                }           
            }
            catch (Exception ex)
            {
                response.Message = "Error:" + ex.Message;
                response.IsSucess = false;
            }
            return response;
        }

    }
}
