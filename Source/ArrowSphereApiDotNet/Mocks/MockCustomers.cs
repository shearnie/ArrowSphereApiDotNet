using ArrowSphereApiDotNet.Models.Customers;
using System;

namespace ArrowSphereApiDotNet.Mocks
{
    public class MockCustomers : ICustomers
    {
        private readonly MockData _testData;

        public MockCustomers(MockData testData)
        {
            _testData = testData;
        }

        public async Task<ListCustomers> ListCustomers()
        {
            return await Task.FromResult(_testData.CustomerList);
        }

        public async Task<CustomerDetails> CustomerDetails(string customerReference)
        {
            return await Task.FromResult(_testData.CustomerList.Data.Customers
                    .Where(i => i.Reference == customerReference)
                    .Select(i => new CustomerDetails()
                    {
                        Status = 200,
                        Data = new ListCustomersData()
                        {
                            Customers = new List<Customer>()
                            {
                                new Customer()
                                {
                                    Reference = i.Reference,
                                    CompanyName = i.CompanyName,
                                    AddressLine1 = i.AddressLine1,
                                    Zip = i.Zip,
                                    City = i.City,
                                    CountryCode = i.CountryCode,
                                    ReceptionPhone = i.ReceptionPhone,
                                    Contact = new Contact()
                                    {
                                        FirstName = i.Contact.FirstName,
                                        LastName = i.Contact.LastName,
                                        Email = i.Contact.Email,
                                        Phone = i.Contact.Phone,
                                        Type = i.Contact.Type,
                                    },
                                }
                            }
                        }
                    })
                    .First());
        }

        private void AddCustomer(Customer customer)
        {
            var original = _testData.CustomerList;
            var newList = _testData.CustomerList.Data.Customers.Where(i => i.Reference != customer.Reference).ToList();
            newList.Add(new Customer()
            {
                Reference = customer.Reference,
                CompanyName = customer.CompanyName,
                AddressLine1 = customer.AddressLine1,
                Zip = customer.Zip,
                City = customer.City,
                CountryCode = customer.CountryCode,
                ReceptionPhone = customer.ReceptionPhone,
                Contact = new Contact()
                {
                    FirstName = customer.Contact.FirstName,
                    LastName = customer.Contact.LastName,
                    Email = customer.Contact.Email,
                    Phone = customer.Contact.Phone,
                    Type = customer.Contact.Type,
                },
            });
            var pagination = new Models.Pagination(
                original.Pagination.Per_Page,
                original.Pagination.Current_Page,
                original.Pagination.Total_Page,
                original.Pagination.Total + 1,
                original.Pagination.Next,
                original.Pagination.Previous);
            _testData.CustomerList = new ListCustomers(original.Status, new ListCustomersData(newList), pagination);
        }

        public async Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest request)
        {
            AddCustomer(new Customer()
            {
                Reference = "XSP123456",
                CompanyName = request.CompanyName,
                AddressLine1 = request.AddressLine1,
                Zip = request.Zip,
                City = request.City,
                CountryCode = request.CountryCode,
                ReceptionPhone = request.ReceptionPhone,
                Contact = new Contact()
                {
                    FirstName = request.Contact.FirstName,
                    LastName = request.Contact.LastName,
                    Email = request.Contact.Email,
                    Phone = request.Contact.Phone,
                    Type = request.Contact.Type,
                },
            });
            return await Task.FromResult(_testData.CustomerList.Data.Customers
                    .Where(i => i.Reference == "XSP123456")
                    .Select(i => new CreateCustomerResponse()
                        {
                            Status = 200,
                            Data = new CreateCustomerResponseData()
                            {
                                Reference = i.Reference,
                            }
                        })
                    .First());
        }

        public async Task<UpdateCustomerResponse> UpdateCustomer(UpdateCustomerRequest request)
        {
            AddCustomer(new Customer()
            {
                Reference = "XSP123456",
                CompanyName = request.CompanyName,
                AddressLine1 = request.AddressLine1,
                Zip = request.Zip,
                City = request.City,
                CountryCode = request.CountryCode,
                ReceptionPhone = request.ReceptionPhone,
                Contact = new Contact()
                {
                    FirstName = request.Contact.FirstName,
                    LastName = request.Contact.LastName,
                    Email = request.Contact.Email,
                    Phone = request.Contact.Phone,
                    Type = request.Contact.Type,
                },
            });

            return await Task.FromResult(_testData.CustomerList.Data.Customers
                    .Where(i => i.Reference == "XSP123456")
                    .Select(i => new UpdateCustomerResponse()
                    {
                        Status = 200,
                        Data = new UpdateCustomerResponseData()
                        {
                            Customers = new List<UpdateCustomerResponseDetail>()
                            {
                                new UpdateCustomerResponseDetail()
                                {
                                    Reference = request.Reference,
                                    CompanyName = request.CompanyName,
                                    AddressLine1 = request.AddressLine1,
                                    Zip = request.Zip,
                                    City = request.City,
                                    CountryCode = request.CountryCode,
                                    ReceptionPhone = request.ReceptionPhone,
                                    Contact = new Contact()
                                    {
                                        FirstName = request.Contact.FirstName,
                                        LastName = request.Contact.LastName,
                                        Email = request.Contact.Email,
                                        Phone = request.Contact.Phone,
                                        Type = request.Contact.Type,
                                    },
                                }
                            },
                        }
                    })
                    .First());
        }

        public async Task<UpdateCustomerResponse> Provision(string customerReference, ProvisionOrMigrationRequest request)
        {
            return await Task.FromResult(new UpdateCustomerResponse());
        }

        public async Task<UpdateCustomerResponse> Migration(string customerReference, ProvisionOrMigrationRequest request)
        {
            return await Task.FromResult(new UpdateCustomerResponse());
        }
    }
}
