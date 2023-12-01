namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ajándék

            List<int> lakosok = new List<int>();
            int lakosokSzama = int.Parse(System.Console.ReadLine());
            int ajandekAr = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < lakosokSzama; i++)
            {
                int lakosMaxBefizetes = int.Parse(System.Console.ReadLine());
                lakosok.Add(lakosMaxBefizetes);
            }

            int kellmegvalakinek = 0;

            if (lakosok.Sum() < ajandekAr)
            {
                System.Console.WriteLine("IMPOSSIBLE!");
            }
            else
            {
                int maradek = 0;
                for (int i = 0; i < lakosok.Count; i++)
                {
                    if (lakosok[i] < ajandekAr / lakosok.Count)
                    {
                        maradek = ajandekAr / lakosok.Count - lakosok[i];
                    }
                    else if (lakosok[i] >= ajandekAr / lakosok.Count)
                    {
                        lakosok[i] += maradek;
                    }
                }
            }
            lakosok.Sort();
            lakosok.ForEach(x => System.Console.WriteLine(x)); //Szar helyen van


            //Négyzet
            int esetek = 1;
            List<int[]> lista = new List<int[]>
            {
                new int[]{2,7,12},
            };
            for (int i = 0; i < lista.Count; i++)
            {
                double terulet = 0;
                int darabSzam = 0;
                double haromszogTerulete = (lista[i][1] * lista[i][2]) / 2;
                while (haromszogTerulete> terulet)
                {
                    if (terulet * Math.Pow(lista[i][0],2)<=haromszogTerulete)
                    {
                        terulet += Math.Pow(lista[i][0], 2);
                        darabSzam++;
                    }
                    else
                    {
                        break;
                    }
                }
                System.Console.WriteLine(darabSzam);
            }
        }
    }
}

