using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEK_CS_Ingwersen
{
    class Program
    {
        static void Main(string[] args)
        {
                List<Geschenk> Liste = new List<Geschenk>();

                Geschenk g;
                bool reversed = false;
                int Geschenknummer = 0;
                string eingabe = "";

                while (eingabe != "E")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Bitte wählen:\n- Beispieldaten erzeugen (B)\n- Anzeigen (A)\n- Hinzufügen (H)\n- Ändern (Ä)\n- Aufsteigend Sortieren (SA)\n- Absteigend Sortieren (SD)\n- Löschen (L)\n- Leeren (X)\n- Ende (E)\n- Ihre Auswahl: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    eingabe = Console.ReadLine();
                    Console.WriteLine();
                    Random rnd = new Random();

                    switch (eingabe)
                    {
                        case "B":                           // Zufallserzeugung geschenken
                            for (int i = 1; i < rnd.Next(1, 20); i = i + 2)
                            {
                                Geschenk_selbst g1 = new Geschenk_selbst(i);
                                Geschenk_kommerziell g2 = new Geschenk_kommerziell(i + 1);
                                Liste.Add(g1);
                                Liste.Add(g2);
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Zufallsgeschenke wurden erzeugt.\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        case "A":                           // Liste ausgeben
                            Console.WriteLine("Geschenkliste:");
                            foreach (Geschenk gesch in Liste)
                            {
                                gesch.Anzeigen();
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Die Liste enthält {0} Geschenk(e).\n", Liste.Count);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        case "H":                           // Geschenk hinzufügen
                            Console.Write("Selbst gebastelt oder gekauft? (s/k): ");
                            eingabe = Console.ReadLine();

                            if (eingabe == "s")
                            {
                                Geschenknummer++;
                                Geschenk_selbst gs = new Geschenk_selbst(Geschenknummer);
                                gs.Eingeben();
                                Liste.Add(gs);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geschenk hinzugefügt.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (eingabe == "k")
                            {
                                Geschenknummer++;
                                Geschenk_kommerziell gk = new Geschenk_kommerziell(Geschenknummer);
                                gk.Eingeben();
                                Liste.Add(gk);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geschenk hinzugefügt.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;

                        case "Ä":                               // Geschenk ändern                      
                            Console.Write("Geschenknummer? ");
                            int nummer = Convert.ToInt32(Console.ReadLine());
                            g = Geschenk.NummerVorhanden(nummer, Liste);
                            if (g == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geschenknummer nicht vorhanden.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                g.Aendern();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geschenk geändert.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;

                        case "L":                            // Geschenk löschen                         
                            Console.Write("Geschenknummer? ");
                            int nummer2 = Convert.ToInt32(Console.ReadLine());
                            g = Geschenk.NummerVorhanden(nummer2, Liste);
                            if (g == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geschenknummer nicht vorhanden.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Liste.Remove(g);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geschenk gelöscht.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;

                        case "X":                           // Geschenkliste leeren
                            Liste.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Geschenkeliste wurde geleert.\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        case "SA":                           // Geschenkliste aufsteigend sortieren
                            Liste.Sort(delegate (Geschenk x, Geschenk y) // vergleicht wie sich nummern gegeneinander verhalten.
                            {
                                if (x.nummer == y.nummer) return 0;
                                else if (x.nummer > x.nummer) return -1;
                                else if (y.nummer < x.nummer) return 1;
                                else return x.nummer.CompareTo(y.nummer);
                            });
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Geschenkeliste wurde aufsteigend sortiert.\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        case "SD":                           // Geschenkliste absteigend sortieren
                            if (reversed)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geschenkeliste ist bereits absteigend sortiert.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Liste.Reverse();
                                reversed = true;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Geschenkeliste wurde absteigend sortiert.\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            break;

                        case "E":                           // Anwendung Ende
                            break;
                    }
                }

            
        }
    }
}
