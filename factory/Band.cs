using System;
namespace factory
{
    class Band {
        public String bandMaat = "";
        // constructor
        public Band(String bandMaat) {
            this.bandMaat = bandMaat;
            Console.WriteLine("Een " + bandMaat + " band s.v.p.");
        }
    }
}