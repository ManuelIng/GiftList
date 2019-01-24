using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEK_CS_Ingwersen
{
    class Geschenk_kommerziell : Geschenk
    {
        protected string hersteller = "Beispielhersteller";

        public Geschenk_kommerziell(int geschenknummer) : base(geschenknummer) { }

        override public void Anzeigen()
        {
            base.Anzeigen();
            Console.WriteLine("Hersteller: {0}", hersteller);
        }

        override public void Aendern()
        {
            base.Aendern();
            Console.Write("Hersteller? ");
            string eingabe = Console.ReadLine();
            if (eingabe != "")
                hersteller = eingabe;
        }

        override public void Eingeben()
        {
            base.Eingeben();
            Console.Write("Hersteller? ");
            hersteller = Console.ReadLine();
        }
    }
}
