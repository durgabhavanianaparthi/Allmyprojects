using System.ComponentModel.DataAnnotations;

namespace One_To_Many_ForeignKey_using.Model
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string? StateName { get; set; }
    }
}
