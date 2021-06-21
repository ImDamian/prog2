using System;
using System.Collections.Generic;

namespace winkelmandje
{
    abstract class Winkelmandje : IWinkelmandje
    {
        public abstract void toonMandje();
        public List<Product> winkelmandje = new List<Product>();

        public void voegToe(Product product)
        {
            winkelmandje.Add(product);
        }
    }
}