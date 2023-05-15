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
            string str = Console.ReadLine();
            Console.Write("What letter are you looking for: ");
            string cnt = Console.ReadLine();
            if (str.Length > 0)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count += 1;
                    }
                }
                Console.WriteLine(cnt + " appears " + count + " times");
            }
            Console.ReadLine();
        }
    }
}
