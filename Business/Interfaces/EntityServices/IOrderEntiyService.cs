using System.Collections.Generic;
using NetCoreApp.Business.Model;

namespace NetCoreApp.Business.Interfaces.EntityServices
{
    public interface IOrderEntiyService
    {
         List<OrderModel> GetOrders();
         bool SaveOrder(OrderModel order);
          OrderModel GetOrder(string orderNumber);
          string  GetOrderNumber();
    }
}