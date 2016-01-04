using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestionale_Pizzeria.Models.BusinessLogic
{
    public class Helpers
    {

        //public static string CalculateMD5Hash(string input)
        //{
        //    // step 1, calculate MD5 hash from input
        //    MD5 md5 = System.Security.Cryptography.MD5.Create();
        //    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        //    byte[] hash = md5.ComputeHash(inputBytes);

        //    // step 2, convert byte array to hex string
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < hash.Length; i++)
        //    {
        //        sb.Append(hash[i].ToString("X2"));
        //    }
        //    return sb.ToString();
        //}

        //public static string EncodeBase64(string source)
        //{
        //    var bytes = Encoding.UTF8.GetBytes(source);
        //    var base64 = Convert.ToBase64String(bytes);
        //    return base64;
        //}

        //public static string DecodeBase64(string source)
        //{
        //    var data = Convert.FromBase64String(source);
        //    var str = Encoding.UTF8.GetString(data);
        //    return str;
        //}

        
    }
}