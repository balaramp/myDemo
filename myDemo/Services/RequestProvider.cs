using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace myDemo.Services
{
    internal class RequestProvider : IRequestProvider
    {
        private HttpClient httpClient;
        JsonSerializerOptions serializerOptions;
        public RequestProvider()
        {
            httpClient = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        Task IRequestProvider.DeleteAsync(string uri, string token)
        {
            throw new NotImplementedException();
        }

        async Task<TResult> IRequestProvider.GetAsync<TResult>(string uri, string token)
        {
            try
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Delete, uri);

                HttpResponseMessage response = await httpClient.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Handle the response
                    return (TResult)handleResponse(responseBody);
                }
                throw new HttpRequestException();
            }
            catch (HttpRequestException)
            {
                // Handle any status codes that indicate an error. 
                // The status code is available in the field e.StatusCode
                throw;
            }
        }

        private object handleResponse(string responseBody)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return JsonSerializer.Deserialize<List<string>>(responseBody, serializerOptions);
#pragma warning restore CS8603 // Possible null reference return.
        }

        Task<TResponse> IRequestProvider.PostAsync<TRequest, TResponse>(string uri, TRequest data, string token, string header)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRequestProvider.PostAsync<TRequest>(string uri, TRequest data, string token, string header)
        {
            throw new NotImplementedException();
        }

        Task<TResult> IRequestProvider.PostAsync<TResult>(string uri, string data, string clientId, string clientSecret)
        {
            throw new NotImplementedException();
        }

        Task<TResult> IRequestProvider.PutAsync<TResult>(string uri, TResult data, string token, string header)
        {
            throw new NotImplementedException();
        }
    }
}
