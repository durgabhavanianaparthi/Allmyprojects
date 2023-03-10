using System.ComponentModel.DataAnnotations;

namespace Many_to_Many_ForeignKeyUsing.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string? ProductName { get; set; }

        public int productPrice { get; set; }
        public virtual ICollection<CustomerProduct>? CustomerProducts { get; set; }



    }

}

