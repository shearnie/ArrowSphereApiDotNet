using ArrowSphereApiDotNet.Models.Customers;
using System;

namespace ArrowSphereApiDotNet
{
    public interface ICustomers
    {
        Task<ListCustomers> ListCustomers();
        Task<CustomerDetails> CustomerDetails(string customerReference);
        Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest request);
        Task<UpdateCustomerResponse> UpdateCustomer(UpdateCustomerRequest request);
        Task<UpdateCustomerResponse> Provision(string customerReference, ProvisionOrMigrationRequest request);
        Task<UpdateCustomerResponse> Migration(string customerReference, ProvisionOrMigrationRequest request);
    }
}
