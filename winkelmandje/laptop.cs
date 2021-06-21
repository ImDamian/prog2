namespace winkelmandje
{

    class Laptop : Product
    {
        private string title;
        private string auteur;

        public Laptop(int id, string title, string auteur, double prijs, int aantal) : base(id, prijs, aantal)
        {
            this.title = title;
            this.auteur = auteur;
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getNaam()
        {
            return (this.auteur);
        }

        public override string getOmschrijving()
        {
            return ("'" + this.title + "' " + this.auteur);
        }
    }
}
