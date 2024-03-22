using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomCode
{
    public class Program
    {
        // Kod üretimi için kullanılacak karakter kümesi
        private const string Charset = "ACDEFGHKLMNPRTXYZ234579";

        // Kod uzunluğu
        private const int CodeLength = 8;

        // Rastgele sayı üretmek için kullanılacak nesne
        private static readonly Random Random = new Random();

        // Yeni bir rastgele kod üretir.
        // Rastgele üretilmiş kod döndürülür.
        public static string GenerateCode()
        {
            // Kod üretimi için kullanılacak karakter dizisi
            char[] code = new char[CodeLength];

            // Rastgele karakterlerle kod oluşturma
            for (int i = 0; i < CodeLength; i++)
            {
                code[i] = Charset[Random.Next(Charset.Length)];
            }

            return new string(code);
        }

        public static void Main(string[] args)
        {
            // Kod üretme örneği
            string generatedCode = GenerateCode();
            Console.WriteLine($"Üretilen Kod: {generatedCode}");
            Console.ReadLine();

        }
    }
}
