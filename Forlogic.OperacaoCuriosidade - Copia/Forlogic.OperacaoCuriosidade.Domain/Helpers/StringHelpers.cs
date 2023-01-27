using System;
using System.Security.Cryptography;
using System.Text;

namespace Forlogic.OperacaoCuriosidade.Domain.Helpers
{
    public static class StringHelpers
    {

        public static string Encrypt(this string senha)
        {

            var salt = "|3EA0A6B62FFC4B138722E04846F70AFB9F9732FF0F5941B48C3E7DED3D4892FA";

            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;
            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }



            return Convert.ToBase64String(hashBytes);
        }
    }
}
