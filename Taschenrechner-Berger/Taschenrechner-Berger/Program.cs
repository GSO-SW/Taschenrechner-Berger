using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Berger
{
    class Program
    {
        static void Main(string[] args)
        {
            string entscheidung;

            do
            {
                //Willkommensgruß + Operationsabfrage
                Console.WriteLine("Willkommen beim Taschenrechner!");
                Console.WriteLine();
                Console.WriteLine("Geben Sie die Rechenoperation (+,-,*,/) an");
                Console.WriteLine("+ Addition");
                Console.WriteLine("- Subtraktion");
                Console.WriteLine("* Multiplikation");
                Console.WriteLine("/ Divison");
                Console.WriteLine();

                char operation = Convert.ToChar(Console.ReadLine());

                //Zahleneingabe
                Console.WriteLine();
                Console.WriteLine("Geben Sie die erste Zahl ein:");
                double zahl1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Geben Sie die zweite Zahl ein:");
                double zahl2 = Convert.ToDouble(Console.ReadLine());

                //Ergebnis mit 0 initialisieren
                double ergebnis = 0;

                //Ergebnis je nach Operation berechnen
                switch (operation)
                {
                    case '+':
                        ergebnis = zahl1 + zahl2;
                        break;
                    case '-':
                        ergebnis = zahl1 - zahl2;
                        break;
                    case '*':
                        ergebnis = zahl1 * zahl2;
                        break;
                    case '/':
                        ergebnis = zahl1 / zahl2;
                        break;
                }

                //Ergebnis ausgeben
                Console.WriteLine();
                Console.WriteLine("Das Ergebnis ist: " + ergebnis);
                Console.WriteLine();

                //Abfrage ob erneut gerechnet werden will
                Console.WriteLine("Wollen Sie erneut rechnen? Geben Sie J oder N ein.");
                entscheidung = Console.ReadLine();
                Console.Clear();
            }
            while (entscheidung == "j" || entscheidung == "J");
        }
    }
}
