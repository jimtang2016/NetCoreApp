using System.Collections.Generic;
using Business.Interfaces.Services;
using NetCoreApp.Business.Interfaces.EntityServices;
using NetCoreApp.Business.Model;
namespace NetCoreApp.Business.Implements
{
    public class BookService:IBookService
    {
        readonly IOrderEntiyService _orderDataService;
        public BookService(IOrderEntiyService orderDataService){
            _orderDataService=orderDataService;
        }
        public List<OrderModel> GetOrderList(){
            
           
            return   _orderDataService.GetOrders();
        }
        public OrderModel GetOrderByNumber(string orderNumber){
                return   _orderDataService.GetOrder(orderNumber);
        }

        public bool SaveOrder(OrderModel order)
        {
           
           return _orderDataService.SaveOrder(order);
        }

        public bool CancelOrder(string orderNumber)
        {
           // using(complete)
            var order=_orderDataService.GetOrder(orderNumber);
            if(order!=null&&order.OrderStatus==OrderSatus.Draft){
             order.OrderStatus=OrderSatus.Canceled;
             _orderDataService.SaveOrder(order);
            }
            return false;
        }
    }
}