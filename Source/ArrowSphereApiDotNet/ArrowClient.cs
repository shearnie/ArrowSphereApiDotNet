using ArrowSphereApiDotNet.Models;
using System;
using System.Net.Http.Json;
using System.Text;

namespace ArrowSphereApiDotNet
{
    public class ArrowClient
    {
        private readonly ArrowConfig _config;
        private readonly HttpClient _httpClient;

        public ArrowClient(
            ArrowConfig config,
            IHttpClientFactory httpClientFactory)
        {
            _config = config;
            _httpClient = httpClientFactory.CreateClient();
        }

        public Partners GetPartnersClient()
        {
            return new Partners(this);
        }

        public Customers GetCustomersClient()
        {
            return new Customers(this);
        }

		public Catalog GetCatalogClient()
		{
			return new Catalog(this);
		}

		public Subscriptions GetSubscriptionsClient()
		{
			return new Subscriptions(this);
		}


		private HttpClient GetHttpClient()
        {
            if (string.IsNullOrEmpty(_config.ApiKey))
            {
                throw new Exception("API Key is required.");
            }

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("apikey", _config.ApiKey);

            return _httpClient;
        }

        private async Task<T> HandleResponseMessage<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                response.EnsureSuccessStatusCode();
                var rs = await response.Content.ReadFromJsonAsync<T>();
                if (rs == null)
                {
                    throw new Exception("No data was returned.");
                }
                return rs;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var rs = await response.Content.ReadFromJsonAsync<ArrowError>();
                if (rs == null || rs.Status == 0)
                {
                    throw new ApplicationException("Bad Request.");
                }
                throw new ArrowException()
                {
                    ArrowError = rs
                };
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                var rs = await response.Content.ReadFromJsonAsync<ArrowError>();
                if (rs == null || rs.Status == 0)
                {
                    throw new ApplicationException("Forbidden Request.");
                }
                throw new ArrowException()
                {
                    ArrowError = rs
                };
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                var rs = await response.Content.ReadFromJsonAsync<ArrowError>();
                if (rs == null || rs.Status == 0)
                {
                    throw new ApplicationException("Internal Server Error.");
                }
                throw new ArrowException()
                {
                    ArrowError = rs
                };
            }
            else
            {
                var rs = await response.Content.ReadFromJsonAsync<ArrowError>();
                if (rs == null || rs.Status == 0)
				{
					throw new ApplicationException($"Unhandled Error, code: {response.StatusCode}.");
				}
                throw new ArrowException()
                {
                    ArrowError = rs
                };
            }
        }

        public async Task<T> GetAsync<T>(string methodPath)
        {
            var get = await GetHttpClient().GetAsync(
                _config.ApiBasePath + methodPath);

            return await HandleResponseMessage<T>(get);
        }

        public async Task<T> PostAsync<T>(string methodPath, string? jsonRequestContent)
        {
            var post = await GetHttpClient().PostAsync(
                _config.ApiBasePath + methodPath,
                new StringContent(jsonRequestContent ?? string.Empty, Encoding.UTF8, "application/json"));

            return await HandleResponseMessage<T>(post);
        }

        public async Task<T> PatchAsync<T>(string methodPath, string? jsonRequestContent)
        {
            var post = await GetHttpClient().PatchAsync(
                _config.ApiBasePath + methodPath,
                new StringContent(jsonRequestContent ?? string.Empty, Encoding.UTF8, "application/json"));

            return await HandleResponseMessage<T>(post);
        }
    }
}
