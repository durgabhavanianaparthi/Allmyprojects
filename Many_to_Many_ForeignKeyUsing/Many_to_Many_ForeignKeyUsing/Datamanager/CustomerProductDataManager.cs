using Many_to_Many_ForeignKeyUsing.Database;
using Many_to_Many_ForeignKeyUsing.Model;
using Many_to_Many_ForeignKeyUsing.Repository;
using Microsoft.EntityFrameworkCore;

namespace Many_to_Many_ForeignKeyUsing.Datamanager
{
    public class CustomerProductDataManager : IDataRepository<CustomerProduct>
    {
        readonly API_DBContext _DBContext;
        public CustomerProductDataManager(API_DBContext dbcontext)
        {
            _DBContext = dbcontext;

        }
        void IDataRepository<CustomerProduct>.Add(CustomerProduct entity)
        {
            var result = new CustomerProduct
            {
                CustomerId = entity.CustomerId,
                ProductId = entity.ProductId,
            };
            _DBContext.Add(result);
            _DBContext.SaveChanges();
        }

        void IDataRepository<CustomerProduct>.Delete(CustomerProduct entity)
        {
            _DBContext.CustomersProducts.Remove(entity);
            _DBContext.SaveChanges();
        }

        CustomerProduct IDataRepository<CustomerProduct>.Get(int id)
        {
             //#pragma warning disable CS8603 // Possible null reference return.

            return _DBContext.CustomersProducts.FirstOrDefault(e => e.CustomerId == id);

            //#pragma warning restore CS8603 // Possible null reference return.
            //return _DBContext.CustomersProducts.Include("CustomersProperties")
            //                 .FirstOrDefault(e => e.CustomerProductId == id);
            //return _DBContext.CustomersProducts.Include("CustomerProperties")
            //                .FirstOrDefault(e => e.CustomerProductId == id);
        }

        public IEnumerable<CustomerProduct> GetAll()
        {
           return _DBContext.CustomersProducts.ToList();
           
        }

        void IDataRepository<CustomerProduct>.Update(CustomerProduct dbEntity, CustomerProduct entity)
        {
            dbEntity.CustomerId = entity.CustomerId;
            dbEntity.ProductId = entity.ProductId;


        }
    }
}
