using System;


namespace Zadanie2
{
      public static class menuLoop
    {
        public static void proceed()
        {
            var a = "";
            do
            {
                printUI();
                a = Console.ReadLine();
                Console.Clear();
                switch (a)
                {
                    case "1": CRUDMenu.read(); break;
                    case "2": CRUDMenu.create(); break;
                    case "3": CRUDMenu.delete(); break;
                    case "4": CRUDMenu.update(); break;
                    case "5": break;
                    default: break;
                }
            } while (a != "5");
        }

        private static void printUI()
        {
            Console.WriteLine("1. Wyswietl tabele Produkty");
            Console.WriteLine("2. Dodaj nowy rekord");
            Console.WriteLine("3. Usun rekordy z id >= 81");
            Console.WriteLine("4. Modyfikuj podukt o wybranym id");
            Console.WriteLine("5. Exit");
        }
    }
}
