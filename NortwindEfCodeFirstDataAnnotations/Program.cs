using NortwindEfCodeFirstDataAnnotations.Contexts;
using NortwindEfCodeFirstDataAnnotations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindEfCodeFirstDataAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var NorthwindContext = new NorthwindContext())
            {
                List<Musteri> musteriler = NorthwindContext.Müsteriler.ToList();
                foreach (var musteri in musteriler)
                {
                    Console.WriteLine("{0}", musteri.Ad);
                }
            }
            Console.ReadLine();
        }
    }
}