using SistemaPECI.Client.Interfaces;
using SistemaPECI.Client.Modelos;
using System.Net.Http.Json;

namespace SistemaPECI.Client.Servicios
{
    public class LoginAPIService : ILoginAPIService
    {
        private readonly HttpClient _http;

        public LoginAPIService(HttpClient http) { 
            _http = http;
        }

        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            Console.WriteLine($"BaseAddress: {_http.BaseAddress}");

            var response = await _http.PostAsJsonAsync("https://localhost:7098/api/login", loginModel);

            if (!response.IsSuccessStatusCode)
                throw new Exception("Error de autenticación");

            return await response.Content.ReadAsStringAsync(); // Aquí se acciona el Token
        }
    }
}
