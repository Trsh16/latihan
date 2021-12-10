using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan
{
    class Program
    {
        public static void main(String[] args)
        {
            int n = 256;
            int[] total = new int[n];
            Console.WriteLine("INPUT KALIMAT : ");
            var kata = Console.ReadLine();
            List<int> KaTa = new List<int>();
            for (int i = 0; i < n; i++)
            {
                total[i] = 0;
            }
            int katakata = kata.Length;
            for (int i = 0; i < katakata; i++)
            {
                total[(int)(char)i]++;
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (total[i] > 0)
                {
                    if (((char)i >= 'a' && (char)i <= 'z'))
                    {
                        Console.WriteLine((char)i + " = " + total[i] + " HURUF");
                    }
                    KaTa.Add(total[i]);
                }
            }
            Console.WriteLine(kata + " = " +KaTa);
            Console.ReadKey();
        }
    }
}