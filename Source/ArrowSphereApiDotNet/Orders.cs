using ArrowSphereApiDotNet.Models.Orders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet
{
    public class Orders
	{
		private readonly ArrowClient _client;

		public Orders(ArrowClient arrowClient)
		{
			_client = arrowClient;
		}

        public async Task<ListOrders> ListOrders()
        {
            return await _client.GetAsync<ListOrders>($"orders");
        }

        public async Task<OrderDetails> OrderDetails(string orderReference)
        {
            return await _client.GetAsync<OrderDetails>($"orders/{orderReference}");
        }

        public async Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request)
        {
            return await _client.PostAsync<CreateOrderResponse>("orders", JsonConvert.SerializeObject(request));
        }
    }
}
