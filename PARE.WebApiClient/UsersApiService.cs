using PARE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PARE.WebApiClient
{
    public class UsersApiService
    {
        private readonly HttpClient _client;
        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        public UsersApiService(Client apiClient)
        {
            _client = apiClient.HttpClient;
        }
        public async Task<TypedResult<LoginResponseModel>> Login(LoginModel model)
        {
            var result = new TypedResult<LoginResponseModel>();
            var url = $"v1/accounts/login";

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _client.PostAsync(url, content);
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

        public async Task<TypedResult<RegisterModel>> Register(RegisterModel model)
        {
            var result = new TypedResult<RegisterModel>();
            var url = $"v1/accounts/register";

            try
            {
                var response = await _client.PostAsJsonAsync(url, model);
                if (!response.IsSuccessStatusCode)
                {
                    result.IsSuccess = false;
                    result.Message = $"Error al conectar con el servicio {response.ReasonPhrase}";
                    return result;
                }

                result = JsonSerializer.Deserialize<TypedResult<RegisterModel>>(await response.Content.ReadAsStringAsync(), jsonOptions);

            }
            catch (Exception)
            {
            }

            return result;
        }
        public async Task<TypedResult<LoginResponseModel>> Profile()
        {
            var result = new TypedResult<LoginResponseModel>();
            var url = $"v1/accounts";
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
        public async Task<TypedResult<RecoverPasswordResponseModel>> RecoverPassword(RecoverPasswordModel model)
        {
            var result = new TypedResult<RecoverPasswordResponseModel>();
            var url = $"v1/accounts/passowrd/recover";
            try
            {
                var response = await _client.PostAsJsonAsync(url, model);
                if (!response.IsSuccessStatusCode)
                {
                    result.IsSuccess = false;
                    result.Message = $"Error al conectar con el servicio {response.ReasonPhrase}";
                    return result;
                }

                result = JsonSerializer.Deserialize<TypedResult<RecoverPasswordResponseModel>>(await response.Content.ReadAsStringAsync(), jsonOptions);

            }
            catch (Exception)
            {
            }

            return result;
        }
    }
}
