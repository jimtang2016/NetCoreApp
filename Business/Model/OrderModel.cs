using System;
using System.Collections.Generic;

namespace NetCoreApp.Business.Model
{
    public class OrderModel
    {
        public string OrderNumber{get;set;}
           public OrderSatus OrderStatus{get;set;}
            public DateTime OrderDate{get;set;}
            public decimal Amount{get;set;}
            public List<SKUItem> OrderItems{get;set;}
    }
    public class SKUItem{
        public string SKU{get;set;}
        public int Quantity{get;set;}
        public decimal UnitPrice{get;set;}
        public Decimal DiscountAmount{get;set;}
    }
    
    /// <summary>
    /// Order status
    /// </summary>
    public enum OrderSatus{
        Draft=1,
        Paying=2,
        Payed=3,
        Failed=4,
        Delivering=5,
        Canceled=6
    }
}