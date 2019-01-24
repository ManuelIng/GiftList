using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEK_CS_Ingwersen
{
    public abstract class Geschenk
    {
        private string bezeichnung = "Beispielbezeichnung";
        public int nummer { get; set; }

        public string Bezeichnung
        {
            get { return bezeichnung; }
            set { bezeichnung = value; }
        }

        public Geschenk(int nummer)
        {
            this.nummer = nummer;
        }

        virtual public void Anzeigen()
        {
            Console.WriteLine("Nummer: {0}", nummer);
            Console.WriteLine("Bezeichnung: {0}", bezeichnung);
        }

        virtual public void Aendern()
        {
            Console.Write("Bezeichnung?");
            string eingabe = Console.ReadLine();
            if (eingabe != "")
                bezeichnung = eingabe;
        }

        virtual public void Eingeben()
        {
            Console.Write("Bezeichnung: ");
            bezeichnung = Console.ReadLine();
        }

        public static Geschenk NummerVorhanden(int nummer, List<Geschenk> Liste)
        {
            foreach (Geschenk g in Liste)
            {
                if (nummer == g.nummer)
                {
                    return g;
                }
            }
            return null;
        }
    }
}
