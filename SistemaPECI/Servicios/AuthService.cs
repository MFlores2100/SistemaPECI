using SistemaPECI.Interfaces;
using SistemaPECI.DTOs;

namespace SistemaPECI.Servicios
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepo;
        private readonly ITokenService _tokenService;

        public AuthService(IUserRepository userRepo, ITokenService tokenService)
        {
            _userRepo = userRepo;
            _tokenService = tokenService;
        }

        public async Task<string> LoginAsync(LoginDTO loginDto)
        {
            var user = await _userRepo.ValidateCredentialAsync(loginDto.Correo, loginDto.Contraseña);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Credenciales inválidas");
            }
            return _tokenService.GenerateToken(user);
        }
    }
}
