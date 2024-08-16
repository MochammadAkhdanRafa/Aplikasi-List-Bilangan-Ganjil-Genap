using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiListBilangaGanjilGenap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi List Bilangan Ganjil Genap");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("Nama : Mochammad akhdan rafa");
            Console.WriteLine("Kelas : X PPLG");
            Console.WriteLine("Absen : 17");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("");
                Console.WriteLine("\nBilangan ganjil:");
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 != 0) // Jika sisa bagi 2 tidak sama dengan 0, maka ganjil
                {
                    Console.WriteLine(i + " ");
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Bilangan genap:");
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0) // Jika sisa bagi 2 sama dengan 0, maka genap
                {
                    Console.WriteLine(i + " ");
                }
            }

        }
    }
}