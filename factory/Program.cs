using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Factory factory = new Factory();
            Fiets batavus = factory.monteren("Batavus", "20.5 inch", "22 inch", "Dames");
            Console.WriteLine(batavus.getSpecificaties());
            Fiets gazelle = factory.monteren("Gazelle", "25 inch", "20 inch", "Heren");
            Console.WriteLine(gazelle.getSpecificaties());
            gazelle.setPrijs(1200);
            Console.WriteLine(gazelle.getSpecificaties());
        }
    }
}
