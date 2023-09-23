using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MvcProject2.Models
{
    public class RepositoryCustomer
    {
        private readonly NorthwindContext _context;

        public RepositoryCustomer(NorthwindContext context)
        {
            _context = context;
        }

        public Customer FindCustomerById(string id)
        {
            var customer = _context.Customers.Find(id);
            return customer;

        }
        public List<Customer> FindCustomerByCustomerID(string id)
        {
            return null;
        }


        public List<string> GetAllCustomerId()
        {
            return _context.Customers.Select(customer => customer.CustomerId).ToList();
        }
        public List<Order> GetOrders(string id)
        {
            List<Customer> customers = _context.Customers.Include(o => o.Orders).ToList();
            Customer customer = customers.FirstOrDefault(x => x.CustomerId == id);
            return customer.Orders.ToList();
        }
        public List<Order> FindCustomersDetailbyOrders(string id)
        {
            List<Customer> ordersWithOrderDetails = _context.Customers.Include(d => d.Orders).ToList();
            Customer cust = ordersWithOrderDetails.FirstOrDefault(x => x.CustomerId == id);
            return cust.Orders.ToList();
        }
        }
}
