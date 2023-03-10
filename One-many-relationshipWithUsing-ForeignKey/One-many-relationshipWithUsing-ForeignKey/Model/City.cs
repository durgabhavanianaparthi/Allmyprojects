using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One_many_relationshipWithUsing_ForeignKey.Model
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public String? CityName { get; set; }
        public int StateId { get; set; }
        [ForeignKey("StateId")]
        public State? State { get; set; }


    }
}
