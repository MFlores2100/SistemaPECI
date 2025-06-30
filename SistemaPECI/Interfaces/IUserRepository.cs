using SistemaPECI.Data.Entidades;

namespace SistemaPECI.Interfaces
{
    public interface IUserRepository
    {
        Task<Usuario?> ValidateCredentialAsync(string correo, string contraseña);
    }
}
