﻿using ArrowSphereApiDotNet.Models.Customers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet
{
    public class Customers
    {
        private readonly ArrowClient _client;

        public Customers(ArrowClient arrowClient)
        {
            _client = arrowClient;
        }

        public async Task<ListCustomers> ListCustomers()
        {
            return await _client.GetAsync<ListCustomers>("customers");
        }

        public async Task<CustomerDetails> CustomerDetails(string customerReference)
        {
            return await _client.GetAsync<CustomerDetails>($"customers/{customerReference}");
        }

        public async Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest request)
        {
            return await _client.PostAsync<CreateCustomerResponse>("customers", JsonConvert.SerializeObject(request));
        }
    }
}
