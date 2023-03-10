using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Many_to_Many_ForeignKeyUsing.Model
{
    public class CustomerProduct
    {
        [Key]
        public long CustomerProductId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        //public virtual ICollection<Customer>? CustomersProperties { get; set; }
        //public virtual ICollection<Product>? CustomerProperties { get; set; }
    }
}
