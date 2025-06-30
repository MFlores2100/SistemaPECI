using SistemaPECI.Client.Modelos;

namespace SistemaPECI.Client.Interfaces
{
    public interface ILoginAPIService
    {
        Task<string> LoginAsync(LoginModel loginModel);
    }
}
