using System;
// See https://aka.ms/new-console-template for more information

namespace SpisLudzi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program 1 Pracownik Firmy");
            Console.WriteLine();

            string firstName = "Osioł";
            string name = "Osłowski";
            int age = 0;
            char sex = 'm';
            string pesel = "01020304056";
            string number = "1";

            Console.Write("Podaj imię: ");
            firstName = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            name = Console.ReadLine();
            Console.Write("Podaj wiek: ");
            string ageFromConsole = Console.ReadLine();
            Console.Write("Podaj płeć: ");
            string sexFromConsole = Console.ReadLine();
            sex = sexFromConsole[0];
            if (!(sex == 'm') && !(sex == 'k') && !(sex == 'M') && !(sex == 'K'))
            {
                Console.WriteLine("Błąd: Płeć nieustalona");
                sex = '-';
            }
            Console.Write("Podaj numer PESEL: ");
            pesel = Console.ReadLine();
            //Int64.TryParse(peselFromConsole, out pesel);
            //if ((pesel < 10000000) || (pesel >= 100000000000))
            //{
            //    Console.WriteLine("Błąd: Błędny numer PESEL!");
            //    pesel = 0;
            //}
            Console.Write("Podaj numer pracownika: ");
            number = Console.ReadLine();

            Int32.TryParse(ageFromConsole, out age);
            
            //Int32.TryParse(numberFromConsole, out number);

            Console.WriteLine($"Imię        : {firstName}");
            Console.WriteLine($"Nazwisko    : {name}");
            Console.WriteLine($"Wiek        : {age}");
            Console.WriteLine($"Płeć        : {sex}");
            Console.WriteLine(value: $"PESEL       : {pesel:00000000000}");
            Console.WriteLine($"Numer       : {number}");

            //Program2
            Console.ReadLine() ;
            Console.WriteLine("Program 2 3 Zmienne");
            Console.WriteLine();
            Console.WriteLine("W tym programie należy podać 3 zmienne jednoliterowe.");
            Console.WriteLine("\nJeśli podasz dłuższe, to i tak je upierdzielę.\n");
            Console.Write("Podaj zmienną 1: ");
            string consoleVariable1 = Console.ReadLine();
            char variable1 = consoleVariable1[0];
            Console.Write("Podaj zmienną 2: ");
            string consoleVariable2 = Console.ReadLine();
            char variable2 = consoleVariable2[0];
            Console.Write("Podaj zmienną 3: ");
            string consoleVariable3 = Console.ReadLine();
            char variable3= consoleVariable3[0];
            Console.WriteLine("Zmienna 3: " + variable3);
            Console.WriteLine("Zmienna 2: " + variable2);
            Console.WriteLine("Zmienna 1: " + variable1);


            //Program3
            Console.ReadLine();
            Console.WriteLine("Program 3 Przekątna");
            Console.WriteLine();

            Console.Write("Podaj długość boku a: ");
            string sideAFromConsole = Console.ReadLine();
            float sideA = 0;
            float.TryParse(sideAFromConsole, out sideA);

            Console.Write("Podaj długość boku b: ");
            string sideBFromConsole = Console.ReadLine();
            float sideB = 0;
            float.TryParse(sideBFromConsole, out sideB);

            double x = Math.Pow(sideA, 2);
            
            double y = Math.Pow(sideB, 2);

            double product = x + y;

            double diagonal = Math.Pow(product, 0.5);


            Console.Write("Przekątna kwadratu : ");
            Console.WriteLine(String.Format("  {0:F20}", diagonal));


            //Program4
            Console.ReadLine();
            Console.WriteLine("Program 4 Szkoła Dotneta");
            Console.WriteLine();
            int a;
            string b;
            double c;

            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");


            //Program5
            Console.ReadLine();
            Console.WriteLine("Program 5 Szpicel");
            Console.WriteLine();
            Console.Write("Podaj imie : ");
            string yourFirstName = Console.ReadLine();
            Console.Write("Podaj nazisko : ");
            string yourName = Console.ReadLine();
            Console.Write("Podaj numer telefonu : ");
            string yourTelephoneNumber= Console.ReadLine();     //Może mieć +, więc na razie dam tu string
            Console.Write("Podaj adres email : ");
            string yourEmailAdress = Console.ReadLine();
            Console.Write("Podaj swój wzrost : ");
            string yourHeightFromConsole = Console.ReadLine();
            float yourHeight = 0;
            float.TryParse(yourHeightFromConsole, out yourHeight);
            Console.Write("Podaj numer buta : ");
            string yourShoeLengthFromConsole = Console.ReadLine();
            float yourShoeLength = 0;
            float.TryParse(yourShoeLengthFromConsole, out yourShoeLength);
            Console.Write("Podaj rok urodzenia : ");
            string yourBirthYearFromConsole = Console.ReadLine();
            Int16 yourBirthYear = 0;
            Int16.TryParse(yourBirthYearFromConsole, out yourBirthYear);
            Console.Write("Ile masz dzieci? ");
            string yourChildrenNumberFromConsole = Console.ReadLine();
            Int16 yourChildrenNumber = 0;
            Int16.TryParse(yourChildrenNumberFromConsole, out yourChildrenNumber);
            Console.Write("Ile ważysz? ");
            string yourWeightFromConsole = Console.ReadLine();
            float yourWeight;
            float.TryParse (yourWeightFromConsole, out yourWeight);

            Console.WriteLine("No a teraz spróbuję wypisać, co mi tu wpisałeś:\n");
            Console.WriteLine($"Imię                : {yourFirstName}");
            Console.WriteLine($"Nazwisko            : {yourName}");
            Console.WriteLine($"Numer telefonu      : {yourTelephoneNumber}");
            Console.WriteLine($"Adres e-mail        : {yourEmailAdress}");
            Console.WriteLine($"Wzrost              : {yourHeight}");
            Console.WriteLine($"Numer buta          : {yourShoeLength}");
            Console.WriteLine($"Rok urodzenia       : {yourBirthYear}");
            Console.WriteLine($"Dzieci              : {yourChildrenNumber}");
            Console.WriteLine($"Waga                : {yourWeight}");
        }
    }
}