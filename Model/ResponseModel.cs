using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebAPI.Model
{
    public class ResponseModel
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public object ResponseData { get; set; }

        //public ResponseModel(bool isSucess, object responseData, string message)
        //{
        //    IsSucess = isSucess;
        //    ResponseData = responseData;          
        //    Message = message; 
        //}

    }
}
