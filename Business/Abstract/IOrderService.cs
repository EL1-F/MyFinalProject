using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order Get(int id);
        List<Order> GetOrderByCity(string city);
        List<Order> GetOrderByCustomer(string customerId);
        List<Order> GetOrderByEmloyee(int employeeId);
    }
}
