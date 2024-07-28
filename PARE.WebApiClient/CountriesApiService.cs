using PARE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PARE.WebApiClient
{
    public class CountriesApiService
    {
        private readonly HttpClient _client;
        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        public CountriesApiService(Client client)
        {
            _client = client.HttpClient;
        }

        public async Task<TypedResult<LoginResponseModel>> GetOne(string countryCode)
        {
            var result = new TypedResult<LoginResponseModel>();
            var url = $"v1/countries/{countryCode}";

            try
            {
                var response = await _client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    result.IsSuccess = false;
                    result.Message = $"Error al conectar con el servicio {response.ReasonPhrase}";
                    return result;
                }

                result = JsonSerializer.Deserialize<TypedResult<LoginResponseModel>>(await response.Content.ReadAsStringAsync(), jsonOptions);

            }
            catch (Exception)
            {
            }

            return result;
        }
    }
}
