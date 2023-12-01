using System;
using System.Text.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ajándék
            //Console.WriteLine("MEHET!");
            //List<int> lakosok = new List<int>();
            //int lakosokSzama = int.Parse(System.Console.ReadLine());
            //int ajandekAr = int.Parse(System.Console.ReadLine());
            //for (int i = 0; i < lakosokSzama; i++)
            //{
            //    int lakosMaxBefizetes = int.Parse(System.Console.ReadLine());
            //    lakosok.Add(lakosMaxBefizetes);
            //}

            //int kellmegvalakinek = 0;

            //if (lakosok.Sum() < ajandekAr)
            //{
            //    System.Console.WriteLine("IMPOSSIBLE!");
            //}
            //else
            //{
            //    int maradek = 0;
            //    for (int i = 0; i < lakosok.Count; i++)
            //    {
            //        if (lakosok[i] < ajandekAr / lakosok.Count)
            //        {
            //            maradek = ajandekAr / lakosok.Count - lakosok[i];
            //        }
            //        else if (lakosok[i] >= ajandekAr / lakosok.Count)
            //        {
            //            lakosok[i] += maradek;
            //        }
            //    }
            //    lakosok.Sort();
            //    lakosok.ForEach(x => System.Console.WriteLine(x));
            //}



            //Négyzet
            //Console.WriteLine("MEHET!");
            //int esetek = 1;
            //List<int[]> lista = new List<int[]>
            //{
            //    new int[]{2,7,12},
            //};
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    double terulet = 0;
            //    int darabSzam = 0;
            //    double haromszogTerulete = (lista[i][1] * lista[i][2]) / 2;
            //    while (haromszogTerulete > terulet)
            //    {
            //        if (terulet * Math.Pow(lista[i][0], 2) <= haromszogTerulete)
            //        {
            //            terulet += Math.Pow(lista[i][0], 2);
            //            darabSzam++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    System.Console.WriteLine(darabSzam);
            //}


            // Arany
            Console.WriteLine("MEHET!");
            //int mennyi = int.Parse(Console.ReadLine());
            //string szamSor = Console.ReadLine();

            //try
            //{
            //    string[] arany = szamSor.Split();

            //    for (int i = 0; i < arany.Length; i++)
            //    {
            //        arany = szamSor.Split();

            //        for (int j = 0; j < arany.Length; j++)
            //        {
            //            if (j == i)
            //            {
            //                j++;
            //            }
            //            else
            //            {

            //            }
            //        }
            //    }


            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Nem jó a megadás módja!!");
            //}























            //Csoki

            int N = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                szamok.Add(int.Parse(input[i]));
            }
            int eredmeny = MaxCsoki(N,szamok);
            Console.WriteLine(eredmeny);

            static int MaxCsoki(int N,List<int> szamok)
            {
                int[] tomb = new int[N];
                int maxCsoki = 0;
                for (int i = N-1; i >= 0; i--)
                {
                    int jelenlegiCsoki = 1;
                    for (int j = i+1; j < N; j++)
                    {
                        if (szamok[j] % szamok[i] == 0)
                        {
                            jelenlegiCsoki = Math.Max(jelenlegiCsoki, tomb[j]);

                        }
                    }
                    tomb[i] = jelenlegiCsoki + 1;
                    maxCsoki = Math.Max(maxCsoki, tomb[i]);
                }
                return maxCsoki;
            }














        }
    }
}