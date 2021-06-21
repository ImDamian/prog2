using System;

namespace winkelmandje
{
    class MijnWinkelmandje : Winkelmandje
    {
        public override void toonMandje()
        {
            Console.WriteLine($"{"id",-20} {"Omschrijving",-40} {"Prijs",9} {"Aantal",6}");
            foreach (Product product in winkelmandje)
            {
                Console.WriteLine(
                    $"{product.getId(),-20} {product.getOmschrijving(),-40} {product.getPrijs().ToString(),9} {product.getAantal().ToString(),6}");
            }
        }


        public void getTotaal() {
            double totaal = 0;
            foreach (Product product in winkelmandje) {
                totaal = totaal + product.getPrijs() * product.getAantal();
            }
            Console.WriteLine($"{"Totaal prijs: "}  {totaal.ToString("0.00")}");
        }
    }
}