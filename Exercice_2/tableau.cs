using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class tableau
    {
        static void Main(string[] args)
        {
            int[] t = { 3, 5, 9, 10, 15 };
            int n, i, p;
            Console.WriteLine("entrez un nombre:");
            int x = Convert.ToInt32(Console.ReadLine());
            t[4] = x;
            for (i = 4; i > 0; i--)
            {
                if (t[i - 1] > x)
                {
                    t[i] = t[i - 1];
                    t[i - 1] = x;
                }
            }

            for (i = 0; i < 5; i++)
            {
                Console.Write("\t" + t[i]);
            }
        }
    }
}
