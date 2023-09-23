using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol;

namespace MvcProject2.Models
{
    public class RepositoryOrders
    {
        private readonly NorthwindContext _context;
        
 
        public RepositoryOrders(NorthwindContext context)
        {
            _context = context;
        }
        public Order FindOrderById(int id)
        {
            var order = _context.Orders.Find(id);
            return order;
        }
		public List<int> GetAllOrderId()
		{
            return (from o in _context.OrderDetails select o.OrderId).ToList();
        }
        
        public List<OrderDetail> FindOrderDetailbyOrderId(int id)
        {
            //Order order = _context.Orders.Find(id);
            //return order.OrderDetails.ToList();
            List<Order> ordersWithOrderDetails = 
                _context.Orders.Include(d => d.OrderDetails).ToList();
            Order order = 
                ordersWithOrderDetails.FirstOrDefault(x => x.OrderId == id);
            return order.OrderDetails.ToList();
        }
        

	}

}

