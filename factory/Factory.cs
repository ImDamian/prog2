using System;
namespace factory
{
    class Factory {
        public Frame frame;
        public Band band;
        public Zadel zadel;
        public Frame maakFrame(String frameMaat) {
            return new Frame(frameMaat);
        }
        public Band maakBand(String bandMaat) {
            return new Band(bandMaat);
        }
        public Zadel maakZadel(String zadelModel) {
            return new Zadel(zadelModel);
        }
        public Fiets monteren(String merk, String frameMaat, String bandMaat, String zadelModel) {
            frame = this.maakFrame(frameMaat);
            band = this.maakBand(bandMaat);
            zadel = this.maakZadel(zadelModel);
            if (merk == "Gazelle"){
                Console.WriteLine("Een Gazelle is gemonteerd");
                return new Gazelle(frameMaat,bandMaat,zadelModel);
            } else if (merk == "Batavus"){
                Console.WriteLine("Een Batavus is gemonteerd");
                return new Batavus(frameMaat,bandMaat,zadelModel);
            } else{
                Console.WriteLine("Kon geen fiets monteren");
                return null;
            }
        }
    }
}