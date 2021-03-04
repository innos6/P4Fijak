using System;
using System.Data.SqlClient;
using System.Globalization;
using Zadanie1;

namespace Zadanie1
{
    class Program 
    {
    static void Main(string[] args)
        {
            using var connection = new SqlConnection("Server = ASUS-PC; Database = ZNorthwind; Integrated Security=true;");
            var a = "0";
            do
            {
                menu.printUI(connection);
                a = Console.ReadLine();
                Console.Clear();
                switch (a)
                {
                    case "1": CRUDMenu.read(connection); break;
                    case "2": CRUDMenu.create(connection); break;
                    case "3": CRUDMenu.delete(connection); break;
                    case "4": CRUDMenu.update(connection); break;
                    case "5": break;
                    default: break;
                }
            } while (a != "5");
        }
    }
}
