using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Comnn
{
    public  sealed class Md5
    {
        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="tempString"></param>
        /// <returns></returns>
        public static string GetMd5(string tempString)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider HashMd5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            return BitConverter.ToString(HashMd5.ComputeHash(Encoding.Default.GetBytes(tempString))).Replace("-", "").ToLower();
        }
    }
}
