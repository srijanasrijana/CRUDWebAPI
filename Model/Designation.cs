using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebAPI.Model
{
    public class Designation
    {

        [Key]
        public int D_ID { get; set; }
        public string Name { get; set; } 
    }
}
