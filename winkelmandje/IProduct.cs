using System;

namespace winkelmandje
{
    public interface IProduct
    {
        string getId();
        double getPrijs();
        int getAantal();
        string getOmschrijving();
    }
}