namespace SistemaPECI.Client.Interfaces
{
    public interface ITokenStorage
    {
        Task<string> GetTokenAsync();
        Task GuardarTokenAsync(string token);
        Task EliminarTokenAsync();
    }
}
