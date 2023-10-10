using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager:IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public Order Get(int id)
        {
            return _orderDal.Get(o=>o.OrderId == id);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public List<Order> GetOrderByCity(string city)
        {
            return _orderDal.GetAll(o => o.ShipCity == city);
        }

        public List<Order> GetOrderByCustomer(string customerId)
        {
            return _orderDal.GetAll(o => o.CustomerId == customerId);
        }

        public List<Order> GetOrderByEmloyee(int employeeId)
        {
            return _orderDal.GetAll(o => o.EmployeeId == employeeId);
        }
    }
}
