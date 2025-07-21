using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace SistemaPECI.Seguridad
{
    public static class Encriptacion
    {
        public static string ConvertirEnHash(string textPlano)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(textPlano));
                return Convert.ToHexString(bytes);
        }
    }
}
