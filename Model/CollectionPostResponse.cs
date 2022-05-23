using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebAPI.Model
{
    public class CollectionPostResponse
    {
        public string responseIsSucess { get; set; } 
        public string responseMessage { get; set; }
        public object responseData { get; set; }
     
    }
}
