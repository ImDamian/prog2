using System;
namespace factory
{
    class Gazelle : Fiets
    {
        // constructor
        public Gazelle(String frameMaat, String bandMaat, String zadelModel)
        {
            this.merk = "Gazelle";
            this.frameMaat = frameMaat;
            this.bandMaat = bandMaat;
            this.zadelModel = zadelModel;
            this.prijs = 999;
        }
    }
}