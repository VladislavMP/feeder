using Model.Entity;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Model.Service
{
    public class AuthService : IAuthService
    {
        SHA256 sha256Hash = SHA256.Create();

        private IRepository<User> _userrepository;
        public AuthService(IRepository<User> userrepository)
        {
            _userrepository = userrepository;
        }
        public short Login(string username, string password)
        {
            User user = _userrepository.Get(username);
            if (user.id == "0")
            {
                return 0; 
            }
            else if (user.password == password)
            {
                return user.account_type; 
            }
            return 0; 
        }

        public short Register(string username, string password, string confirm_password)
        {
            

            User user = _userrepository.Get(username);
            if (user == null) return 1;
            else if (password.Length < 8) return 2;
            
            string pass_hash = GetHash(sha256Hash, password);

            if (VerifyHash(sha256Hash, confirm_password, pass_hash))
            {
                User new_user = new User(username, pass_hash, 0);
                return 0;
            }
            else
            {
                return 3;
            }

        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            var hashOfInput = GetHash(hashAlgorithm, input);
            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
