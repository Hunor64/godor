using System;
using System.IO;
using System.Linq;

namespace EMELET
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat
            List<int> adatok = File.ReadAllLines("melyseg.txt").Select(x=>int.Parse(x)).ToList();
            Console.WriteLine("1. feladat");
            Console.WriteLine($"A fájl adatainak száma: {adatok.Count}");
            Console.WriteLine();

            // 2. feladat
            Console.Write("Adjon meg egy távolságértéket! ");
            int kezdo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ezen a helyen a felszín 2 méter mélyen van.");
            Console.WriteLine();

            // 3. feladat
            int uresek = adatok.Count(a => a == 0);
            double aranya = uresek / (adatok.Count*1.0);
            Console.WriteLine("3. feladat");
            Console.WriteLine($"Az érintetlen terület aránya {Math.Round(aranya * 100,2)}%.");
            Console.WriteLine();
            
            // 4. feladat
            File.WriteAllLines("godrok.txt", adatok.Select(x => x.ToString()));
            
            // 5. feladat
            int godorok = adatok.Count - 2;
            Console.WriteLine("5. feladat");
            Console.WriteLine("A gödrök száma: {0}", godorok);
            Console.WriteLine();
            
            // 6. feladat
            Console.WriteLine("6. feladat");
            Console.WriteLine($"a) A gödör kezdete: {kezdo}, a gödör vége: {adatok.Count - 1}.");
            int legnagyobb = int.MinValue;
            for (int i = kezdo; i < adatok.Count; i++)
            {
                if (adatok[i] > legnagyobb)
                {
                    legnagyobb = adatok[i];
                }
            }
            Console.WriteLine($"c) A gödör legnagyobb mélysége: {legnagyobb} méter.");
            int terfogat = legnagyobb * (adatok.Count - kezdo - 1) * 10;
            Console.WriteLine($"d) A gödör térfogata: {terfogat} m^3.");
            Console.WriteLine($"e) A vízmennyiség: {terfogat - 10 * 10} m^3.");
        }
    }
}
