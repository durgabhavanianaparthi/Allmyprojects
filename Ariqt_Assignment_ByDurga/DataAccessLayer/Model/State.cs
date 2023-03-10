using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public  class State
    {
        [Key]
        public int StateId { get; set; }
        public string? StateName { get; set; }
        public string? State_CM { get; set;}

        public long? TotalStatePopulation { get; set; }
        //DataAnnotation
        //[Required(ErrorMessage = "Telephone number is required.")]
        //[RegularExpression(@"^[6-9][0-9]{9}$", ErrorMessage = "Invalid mobile number format. Indian mobile numbers must start with either 9, 8, 7, or 6 and contain 10 digits.")]
        public long? TollFreeNumber { get; set; }

    }
}
