using System;

namespace Exerciec2
{
    class tableau
    {
        static void Main(string[] args)
        {
            int[] tab1 = new int[] { 3, 5, 10, 15, 20 };
            int[] tab2 = tab1;

            int nbr;
            Console.WriteLine("Entrez le nombre : ");
            nbr = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < tab1.Length)
            {
                tab2[i] = tab1[i];
                i++;

            }
            tab2[tab1.Length] = nbr;
            for (int j = tab2.Length - 1; j >= 0; j--)
            {
                if (nbr < tab2[j])
                {
                    int aide = tab2[j];
                    tab2[j] = nbr;
                    nbr = aide;
                }
            }

            tab1 = tab2;
        }
    }
}