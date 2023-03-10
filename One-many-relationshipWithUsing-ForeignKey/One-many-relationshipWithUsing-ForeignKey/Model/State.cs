using System.ComponentModel.DataAnnotations;

namespace One_many_relationshipWithUsing_ForeignKey.Model
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string? StateName{ get; set; }



    }
}
