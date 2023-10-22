using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentenceSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle yazınız : ");
            string ifade = Console.ReadLine().ToLower();
            char[] sesli = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            string[] arr = new string[ifade.Length];

            int sayac = 0;
            foreach (var item in ifade)
            {
                foreach (var ünlü in sesli)
                {
                    if (item == ünlü )
                    {
                        sayac++; 
                        arr[sayac] = item.ToString(); 
                    }

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);  

            }
            Console.ReadLine();
        }
    }
}
