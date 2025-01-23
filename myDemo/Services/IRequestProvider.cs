using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo.Services
{
    internal interface IRequestProvider
    {
        Task<TResult> GetAsync<TResult>(string uri, string token = "");

        Task<TResponse> PostAsync<TRequest, TResponse>(string uri, TRequest data, string token = "", string header = "");

        Task<bool> PostAsync<TRequest>(string uri, TRequest data, string token = "", string header = "");

        Task<TResult> PostAsync<TResult>(string uri, string data, string clientId, string clientSecret);

        Task<TResult> PutAsync<TResult>(string uri, TResult data, string token = "", string header = "");

        Task DeleteAsync(string uri, string token = "");
    }
}
