using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebAPI.Model
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; } 

        [Required(ErrorMessage = "Please enter FirstName")]
        [Column(TypeName ="varchar(100)")]
        public string StaffFirstName { get; set; }

        [Required(ErrorMessage ="Please enter LastName")]
        [Column(TypeName ="varchar(100)")]
        public string StaffLastName { get; set; }

        [Required]
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")] 
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please Enter Designation")]
        [Column(TypeName = "varchar(100)")]
        public string DesignationName { get; set; } 

        [Required]
        public int D_ID { get; set; } 
        [ForeignKey("D_ID")]
        public virtual Designation Designation { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        public string Gender { get; set; }


         



    }
}
