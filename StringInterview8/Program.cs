using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterview8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            Console.Write("What letter are you looking for? ");
            string let = Console.ReadLine();

            int a = 0;

            for (int lcv = 0; lcv < text.Length; lcv++) {
                char lett = text[lcv];
                if (lett = "a") { a += 1;  }
            }
        }
    }
}
