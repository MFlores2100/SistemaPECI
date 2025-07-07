using SistemaPECI.Client.Interfaces;
using System.Threading.Tasks;

namespace SistemaPECI.Client.Seguridad
{
    public class InMemoryTokenStorage : ITokenStorage
    {
        private string? _token;
        public Task<string> GetTokenAsync()
        {
            return Task.FromResult(_token ?? string.Empty);
        }

        public Task GuardarTokenAsync(string token)
        {
            _token = token;
            return Task.CompletedTask;
        }

        public Task EliminarTokenAsync()
        {
            _token = null;
            return Task.CompletedTask;
        }
    }
}
