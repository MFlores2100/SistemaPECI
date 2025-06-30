using SistemaPECI.Data.Entidades;

namespace SistemaPECI.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(Usuario usuario);
    }
}
