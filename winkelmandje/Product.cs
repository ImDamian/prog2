using System;
using System.Collections.Generic;

namespace winkelmandje
{
    abstract class Product : IProduct
    {
        private int id;
        private double prijs;
        private int aantal;

        public Product(int id, double prijs, int aantal)
        {
            this.id = id;
            this.prijs = prijs;
            this.aantal = aantal;
        }

        public string getId()
        {
            return this.id.ToString();
        }

        public double getPrijs()
        {
            return this.prijs;
        }

        public int getAantal()
        {
            return this.aantal;
        }

        public abstract string getOmschrijving();
    }
}