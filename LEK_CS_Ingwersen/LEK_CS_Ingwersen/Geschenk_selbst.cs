using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEK_CS_Ingwersen
{
    class Geschenk_selbst : Geschenk
    {
        protected int schwierigkeitsgrad = 1;

        public Geschenk_selbst(int geschenknummer) : base(geschenknummer) { }

        override public void Anzeigen()
        {
            base.Anzeigen();
            Console.WriteLine("Schwierigkeitsgrad: {0}", schwierigkeitsgrad);
        }

        override public void Aendern()
        {
            base.Aendern();
            int wunschgrad;
            do
            {
                Console.Write("Schwierigkeitsgrad? (1,2 oder 3)");
                wunschgrad = Convert.ToInt32(Console.ReadLine());

            } while (wunschgrad > 3); // while (wunschgrad !=1 || wunschgrad !=2 ||wunschgrad !=3) geht nicht warum????????
            schwierigkeitsgrad = wunschgrad;
        }

        override public void Eingeben()
        {
            base.Eingeben();
            int wunschgrad;
            do
            {
                Console.Write("Schwierigkeitsgrad? (1,2 oder 3)");
                wunschgrad = Convert.ToInt32(Console.ReadLine());
            } while (wunschgrad > 3);
            schwierigkeitsgrad = wunschgrad;
        }
    }
}
