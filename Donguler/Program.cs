using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampusu";

            Console.WriteLine(kurs1);

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampusu","Programlamaya başlangıç temel kurs","java","python" };


            for (int i = 0; i < kurslar.Length; i++)
            {

                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
