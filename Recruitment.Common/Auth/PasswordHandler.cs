using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace IPMATS.Common.Auth
{
   public  class PasswordHandler : IPasswordHandler
    {
        /// <summary>
        /// The CreatePasswordHash
        /// </summary>
        /// <param name="pwd">The pwd<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string CreatePasswordHash(string pwd)
        {
            return CreatePasswordHash(pwd, CreateSalt());
        }

        /// <summary>
        /// The CreatePasswordHash 
        /// </summary>
        /// <param name="pwd">The pwd<see cref="string"/></param>
        /// <param name="salt">The salt<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        private string CreatePasswordHash(string pwd, string salt)
        {
            string saltAndPwd = String.Concat(pwd, salt);
            string hashedPwd = GetHashString(saltAndPwd);
            var saltPosition = 5;
            hashedPwd = hashedPwd.Insert(saltPosition, salt);
            return hashedPwd;
        }

        /// <summary>
        /// The Validate
        /// </summary>
        /// <param name="password">The password<see cref="string"/></param>
        /// <param name="passwordHash">The passwordHash<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Validate(string password, string passwordHash)
        {
            var saltPosition = 5;
            var saltSize = 10;
            var salt = passwordHash.Substring(saltPosition, saltSize);
            var hashedPassword = CreatePasswordHash(password, salt);
            return hashedPassword == passwordHash;
        }

        /// <summary>
        /// The CreateSalt
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        private string CreateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[20];
            rng.GetBytes(buff);
            var saltSize = 10;
            string salt = Convert.ToBase64String(buff);
            if (salt.Length > saltSize)
            {
                salt = salt.Substring(0, saltSize);
                return salt.ToUpper();
            }

            var saltChar = '^';
            salt = salt.PadRight(saltSize, saltChar);
            return salt.ToUpper();
        }

        /// <summary>
        /// The GetHashString
        /// </summary>
        /// <param name="password">The password<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        private string GetHashString(string password)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(password))
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        /// <summary>
        /// The GetHash
        /// </summary>
        /// <param name="password">The password<see cref="string"/></param>
        /// <returns>The <see cref="byte[]"/></returns>
        private byte[] GetHash(string password)
        {
            SHA384 sha = new SHA384CryptoServiceProvider();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        }


        public int GenerateRandomNumber()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}
