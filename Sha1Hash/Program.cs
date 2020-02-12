using System;
using System.Security.Cryptography;
using System.Text;

namespace Sha1Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the UPC/EAN code\n");
            string userinput = Console.ReadLine();
            Console.WriteLine(GetDigitEyesVerificationCode(userinput));
            Console.ReadLine();
        }

        public static string GetDigitEyesVerificationCode(string UpcCode) 
        {
            var hmac = new HMACSHA1(Encoding.UTF8.GetBytes("/0uMHZvhbeTw")); 
            var m = hmac.ComputeHash(Encoding.UTF8.GetBytes(UpcCode)); 
            return Convert.ToBase64String(m); 
        }
    }
}
