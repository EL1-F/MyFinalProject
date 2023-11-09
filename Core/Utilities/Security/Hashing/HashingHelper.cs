using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        { // password verip >> out byte[] passwordHash, out byte[] passwordSalt döndüreceğiz.
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                // bir string in byte değerini almak istiyorsak >> Encoding.UTF8.GetBytes(password)
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) // HMACSHA512(passwordSalt) >> verdiğimiz Key e göre hash le diyoruz.
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i<computedHash.Length;i++) //byte array olduğu için for döngüsüyle dönüyoruz ve tamamen doğru olduğunda true dönüyor.
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
