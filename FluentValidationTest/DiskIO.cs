using System;
using System.IO;

namespace FluentValidationTest
{
    public class DiskIO
    {
        public static string ReadValidationData()
        {
            return File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\ValidationData.json");
        }
    }
}
