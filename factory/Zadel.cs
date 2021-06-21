using System;
namespace factory
{
    class Zadel {
        public String zadelModel = "";
        // constructor
        public Zadel(String zadelModel) {
            this.zadelModel = zadelModel;
            Console.WriteLine("Een " + zadelModel + "zadel s.v.p.");
        }
    }
}