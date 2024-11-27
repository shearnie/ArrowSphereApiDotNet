using ArrowSphereApiDotNet.Models.Licenses;
using System;

namespace ArrowSphereApiDotNet
{
    public interface ILicenses
    {
        Task<ListLicenses> ListLicenses(int? page = null, int? perPage = null, string? searchBefore = null, string? searchAfter = null);
        Task<LicenseDetails> LicenseDetails(string licenseReference);
        Task<UpdateLicenseResponse> UpdateLicense(string licenseReference, UpdateLicenseRequest request);
		Task<UpdateLicenseSeatsResponse> UpdateLicenseSeats(string licenseReference, UpdateLicenseSeatsRequest request);
		Task<CancelLicenseResponse> CancelLicense(string licenseReference, CancelLicenseRequest request);
	}
}
