using BusinessLogicLayer.Concreate;
using DataAccessLayer.Concreate.Contex.EntityFramework;
using System;
using System.Linq;

namespace TestDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryManager category = new CategoryManager(new EfCategory(new AlGulumVerGulumDbContex()));
            //var result = category.Add(new Entity.POCO.Category() { Name = "Genç" });
            //if (result)
            //{
            //    Console.WriteLine("Eklendi");
            //}

            //AlGulumVerGulumDbContex db = new AlGulumVerGulumDbContex();
            //db.Product.Add(new Entity.POCO.Product { Name = "Sarı Top(Gülen Yüz)", Price = 5, Stok = 4, });
            //if (db.SaveChanges()>0)
            //{
            //    Console.WriteLine("Eklendi");
            //}
            //foreach (var item in db.Product.ToList())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //for (long i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine("{0}!={1}!", i, FaktoriyelHesap(i));
            //}

            //Console.WriteLine();
        }
        //public static long FaktoriyelHesap(long sayi)
        //{
        //    if (sayi<=1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return sayi * FaktoriyelHesap(sayi - 1);
        //    }
        //}
    }
}
