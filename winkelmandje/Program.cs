using System;

namespace winkelmandje
{
    class Program
    {
        static void Main(string[] args)
        {
            MijnWinkelmandje mijnwinkelmandje = new MijnWinkelmandje();
            mijnwinkelmandje.voegToe(new Boek(1, "A little Life", "Hanya Yanagihara", 12.32, 1));
            mijnwinkelmandje.voegToe(new Laptop(2, "Toshiba", "Satellite", 54.21, 2));
            mijnwinkelmandje.toonMandje();
            mijnwinkelmandje.getTotaal();
        }
    }
}