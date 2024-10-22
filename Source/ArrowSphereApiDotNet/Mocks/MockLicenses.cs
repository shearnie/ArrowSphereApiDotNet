using ArrowSphereApiDotNet.Models.Licenses;
using System;

namespace ArrowSphereApiDotNet.Mocks
{
    public class MockLicenses : ILicenses
    {
        private readonly MockData _testData;

        public MockLicenses(MockData testData)
        {
            _testData = testData;
        }

        public async Task<ListLicenses> ListLicenses(int? page = null, int? perPage = null, string? searchBefore = null, string? searchAfter = null)
        {
            return await Task.FromResult(_testData.Licenses);
        }

        public async Task<LicenseDetails> LicenseDetails(string licenseReference)
        {
            return await Task.FromResult(_testData.Licenses.Data.Licenses
                    .Where(i => i.License_Id == licenseReference)
                    .Select(i => new LicenseDetails()
                    {
                        Status = 200,
                        Data = new LicenseDetailsData()
                        {
                            License = new LicenseDetailsLicense(
                                i.Activation_Datetime,
                                i.ActiveSeats,
                                i.ArrowSubCategories,
                                i.AssociatedSubscriptionProgram,
                                i.AutoRenew,
                                i.Category,
                                i.Customer_Ref,
                                i.Expiry_Datetime,
                                i.FriendlyName,
                                i.IsAddon,
                                i.IsTrial,
                                i.License_Id,
                                string.Empty,
                                i.Parent_License_Id,
                                i.Name,
                                i.Message,
                                i.Order,
                                i.Periodicity,
                                i.PeriodicityCode,
                                i.Price,
                                i.PriceBand,
                                i.Program,
                                new Rates(),
                                i.Seats,
                                i.Service_Ref,
                                i.Sku,
                                i.State,
                                i.StatusCode,
                                i.Term,
                                i.TermCode,
                                i.VendorBillingId,
                                string.Empty,
                                i.Vendor_Code,
                                i.Vendor_License_Id,
                                new Assets(),
                                string.Empty,
                                new List<Config>(),
                                string.Empty,
                                new DateTime(),
                                i.Order.Reference,
                                new List<Relation>(),
                                new List<Warning>()
                            ),
                        }
                    })
                    .First());
        }

        public async Task<UpdateLicenseResponse> UpdateLicense(string licenseReference, UpdateLicenseRequest request)
        {
            return await Task.FromResult(new UpdateLicenseResponse()
                {
                    Status = 200,
                    Error = "Accepted",
                    Messages = new List<string>() { "Warning: The desired seat count 10 exceeded the maximum seat count allowed per License 5\"" },
                });
        }
    }
}
