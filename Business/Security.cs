using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Text;

namespace Business
{
    public static class Security
    {
        public static string Encrypt(string text)
        {
            StringBuilder bodyBuilder;

            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                bodyBuilder = new StringBuilder();

                for(int i = 0; i < data.Length; i++)
                {
                    bodyBuilder.Append(data[i].ToString("x2"));
                }
            }
            return bodyBuilder.ToString();
        }

        public static bool VerifyInput(string thisInput, string xInput)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (comparer.Compare(Encrypt(thisInput), xInput) == 0) return true;
            return false;
        }
    }
}
