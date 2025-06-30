using SistemaPECI.DTOs;

namespace SistemaPECI.Interfaces
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginDTO loginDTO);
    }
}
