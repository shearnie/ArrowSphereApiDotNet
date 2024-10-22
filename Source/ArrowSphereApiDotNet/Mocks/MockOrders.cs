using ArrowSphereApiDotNet.Models.Customers;
using ArrowSphereApiDotNet.Models.Orders;
using System;

namespace ArrowSphereApiDotNet
{
    public class MockOrders : IOrders
    {
        private readonly MockData _testData;

        public MockOrders(MockData testData)
        {
            _testData = testData;
        }

        public async Task<ListOrders> ListOrders()
        {
            return await Task.FromResult(_testData.Orders);
        }

        public async Task<OrderDetails> OrderDetails(string orderReference)
        {
            return await Task.FromResult(_testData.Orders.Data.Orders
                    .Where(i => i.Reference == orderReference)
                    .Select(i => new OrderDetails()
                    {
                        Status = 200,
                        Data = new OrderDetail()
                        {
                            Orders = new List<Order>()
                            {
                                new Order()
                                {
                                    Reference = i.Reference,
                                    Status = i.Status,
                                    DateStatus = i.DateStatus,
                                    DateCreation = i.DateCreation,
                                    PoNumber = i.PoNumber,
                                    Partner = i.Partner,
                                    Customer = i.Customer,
                                    Products = i.Products,
                                    CreatedBy = i.CreatedBy,
                                    CreatedByImpersonator = i.CreatedByImpersonator,
                                    CommitmentAmountTotal = i.CommitmentAmountTotal,
                                }
                            },
                        },
                    })
                    .First());
        }

        public async Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request)
        {
            return await Task.FromResult(new CreateOrderResponse()
            {
                Status = 200,
                Data = new CreateOrderResponseData()
                {
                    Reference = "XSPO123456",
                    Link = "/api/orders/XSPO123456",
                }
            });
        }

        public async Task<CancelOrderResponse> CancelOrder(string orderReference)
        {
            return await Task.FromResult(new CancelOrderResponse()
            {
                Status = 200,
                Data = new CancelOrderResponseData()
                {
                    Message = $"Order with reference {orderReference} has been cancelled",
                }
            });
        }
    }
}
