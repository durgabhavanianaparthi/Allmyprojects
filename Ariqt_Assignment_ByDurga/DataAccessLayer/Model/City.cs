using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public  class City
    {
       
            [Key]
            public int CityId { get; set; }
            public String? CityName { get; set; }
            public int? TotalCityPopulation { get; set; }
            public   int LiteracyRate { get; set; } 
            public int StateId { get; set; }
            [ForeignKey("StateId")]
            public State State { get; set; }
      
    }
}
