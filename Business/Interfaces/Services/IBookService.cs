using System.Collections.Generic;
using NetCoreApp.Business.Model;

namespace Business.Interfaces.Services
{
    public interface IBookService
    {
         List<OrderModel> GetOrderList();
        OrderModel GetOrderByNumber(string orderNumber);
        bool SaveOrder(OrderModel order);
        bool CancelOrder(string orderNumber);
    }
}