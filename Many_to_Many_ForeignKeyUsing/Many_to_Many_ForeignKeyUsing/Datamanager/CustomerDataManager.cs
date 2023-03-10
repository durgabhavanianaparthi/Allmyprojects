﻿using Many_to_Many_ForeignKeyUsing.Database;
using Many_to_Many_ForeignKeyUsing.Model;
using Many_to_Many_ForeignKeyUsing.Repository;
using Microsoft.EntityFrameworkCore;

namespace Many_to_Many_ForeignKeyUsing.Datamanager
{
    public class CustomerDataManager : IDataRepository<Customer>
    {
        readonly API_DBContext _DBContext;
        public CustomerDataManager(API_DBContext dbcontext)
        {
            _DBContext = dbcontext;
        }
        public void Add(Customer entity)
        {
            //_DBContext.Customers.Add(entity);
            //_DBContext.SaveChanges();
            var abc = new Customer
            {
                CustomerName = entity.CustomerName,
                CustomerAddress = entity.CustomerAddress,
                CustomerAge = entity.CustomerAge,

               // CustomerId = entity.CustomerId
            };
            _DBContext.Add(abc);
            _DBContext.SaveChanges();
        }

        public void Delete(Customer customer )
        {
            _DBContext.Customers.Remove(customer);
            _DBContext.SaveChanges();
        }

//        public Customer Get(long id)
//        {
//#pragma warning disable CS8603 // Possible null reference return.
//            return _DBContext.Customers.Include("CustomerProducts")
//                  .FirstOrDefault(e => e.CustomerId == id);
//#pragma warning restore CS8603 // Possible null reference return. 
//        }

        public Customer Get(int id)
        {
//#pragma warning disable CS8603 // Possible null reference return.
            return _DBContext.Customers.Include("CustomerProducts")
                  .FirstOrDefault(e => e.CustomerId == id);
//#pragma warning restore CS8603 // Possible null reference return. 
        }

        public IEnumerable<Customer> GetAll()
        {
            return _DBContext.Customers.ToList();
            //var result = from customers in _DBContext.Customers join products in _DBContext  
        }
    

        public void Update(Customer dbEntity, Customer entity)
        {
            dbEntity.CustomerName = entity.CustomerName;
            dbEntity.CustomerAddress = entity.CustomerAddress;
            dbEntity.CustomerAge = entity.CustomerAge;
            _DBContext.SaveChanges();
        }
    }
}
