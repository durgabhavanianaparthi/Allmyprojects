using System.ComponentModel.DataAnnotations;

namespace Many_to_Many_ForeignKeyUsing.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public int CustomerAge { get; set; }
        public string? CustomerAddress { get; set; }
        public virtual ICollection<CustomerProduct>? CustomerProducts { get; set; }
    }
}
