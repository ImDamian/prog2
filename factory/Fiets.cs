using System;
namespace factory{
    class Fiets {
        protected string merk;
        protected string frameMaat;
        protected string bandMaat;
        protected string zadelModel;
        protected double prijs;

        public string getSpecificaties(){
            return "Specificaties:\nMerk: " + this.merk + " Frame: " + this.frameMaat + " BandMaat: " + this.bandMaat + " Zadel model: " + this.zadelModel + " Prijs: " + this.prijs + "\n----------------------------------------------------------------";
        }
        public void setPrijs(double prijs) {
            this.prijs = prijs;
            Console.WriteLine("Prijs van " + this.merk + " is veranderd");
        }
    }
}