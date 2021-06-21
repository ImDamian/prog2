using System;
namespace factory
{
    class Batavus : Fiets {
        // constructor
        public Batavus(string frameMaat, string bandMaat, string zadelModel) {
            this.merk = "Batavus";
            this.frameMaat = frameMaat;
            this.bandMaat = bandMaat;
            this.zadelModel = zadelModel;
            this.prijs = 1000;
        }
    }
}
