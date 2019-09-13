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
                Console.WriteLine("Willkommen beim Taschenrechner!");
                Console.WriteLine("Geben Sie die Rechenoperation (+,-,*,/) an");
                Console.WriteLine("+ Addition");
                Console.WriteLine("- Subtraktion");
                Console.WriteLine("* Multiplikation");
                char operation = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Geben Sie die erste Zahl ein:");
                double zahl1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Geben Sie die zweite Zahl ein:");
                double zahl2 = Convert.ToDouble(Console.ReadLine());

                double ergebnis = 0;

                switch(operation)
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
                }

                Console.WriteLine("Das Ergebnis ist: " + ergebnis);

                Console.WriteLine("Wollen Sie erneut rechnen? Geben Sie J oder N ein.");
                entscheidung = Console.ReadLine();
                Console.Clear();
            }
            while (entscheidung == "j" || entscheidung == "J");
        }
    }
}
