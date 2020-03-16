using IPMATS.Common.Auth;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using static UUL.Logger.UUL.Core.UUL.Common.Enums.Enums;

namespace IPMATS.Common.Helper
{
 
    public class TripleDES
    {
        private char v;
        #region Properties
        private string Key { get; set; }
       // private ICurrentUser CurrentUser { get; set; }
        #endregion
        #region Constructor
        public TripleDES(string key/*, ICurrentUser currentUser*/)
        {
            this.Key = key;
            //CurrentUser = currentUser;
        }

        public TripleDES(char v)
        {
            this.v = v;
        }
        #endregion
        #region Methods
        /// <summary>
        /// 3DES Encryption
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <param name="useHashing"></param>
        /// <returns></returns>
        public string Encrypt(string toEncrypt, bool useHashing = true)
        {
            #region Declare return type with initial value
            string result = string.Empty;
            #endregion
            try
            {
                byte[] keyArray;
                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key));
                    hashmd5.Clear();
                }
                else
                {
                    keyArray = UTF8Encoding.UTF8.GetBytes(Key);
                }
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                tdes.Clear();
                result = Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch (System.Exception exception)
            {
                //Logger.Instance.LogException(exception, "", MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Critcal);
            }
            return result;
        }
        /// <summary>
        /// 3DES Decryption
        /// </summary>
        /// <param name="cipherString"></param>
        /// <param name="useHashing"></param>
        /// <returns></returns>
        public string Decrypt(string cipherString, bool useHashing = true)
        {
            #region Declare return type with initial value
            string result = string.Empty;
            #endregion
            try
            {
                byte[] keyArray;
                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key));
                    hashmd5.Clear();
                }
                else
                {
                    keyArray = UTF8Encoding.UTF8.GetBytes(Key);
                }
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);
                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                tdes.Clear();
                result = UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (System.Exception exception)
            {
         //       Logger.Instance.LogException(exception, "", MethodBase.GetCurrentMethod(), DateTime.Now.ToShortTimeString(), LogLevel.Medium);
            }
            return result;
        }
        #endregion
    }
}
