using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.WebApiClient
{
    public class Client : IApiClient
    {
        public Client()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("https://recipay-api.server.edunet.com.co/");
        }
        public HttpClient HttpClient { get; set; }
        public void SetAutorization(string token)
        {
            RemoveAutorization();
            HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        }

        public void RemoveAutorization()
        {
            HttpClient.DefaultRequestHeaders.Remove("Authorization");
        }
    }

    public interface IApiClient
    {
        HttpClient HttpClient { get; set; }
        public void SetAutorization(string token);
        public void RemoveAutorization();
    }
}
