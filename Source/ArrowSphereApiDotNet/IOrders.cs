using ArrowSphereApiDotNet.Models.Orders;
using System;

namespace ArrowSphereApiDotNet
{
    public interface IOrders
    {
        Task<ListOrders> ListOrders();
        Task<OrderDetails> OrderDetails(string orderReference);
        Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request);
        Task<CancelOrderResponse> CancelOrder(string orderReference);
    }
}
