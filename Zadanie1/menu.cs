using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Globalization;

namespace Zadanie1
{
    public static class menu
    {
        public static void printUI(SqlConnection connection)
        {
            int nextId =0;
            try
            {
                connection.Open();
                var querry = "DECLARE @lastId INT =  (SELECT MAX(Produkty.IDproduktu) FROM mg.Produkty)+1" +
                             "SELECT @lastId  ";
                using var command = new SqlCommand(querry, connection);
                var result = command.ExecuteScalar();
                connection.Close();
                nextId = int.Parse(result.ToString());
                Console.WriteLine("1. Wyswietl tabele Produkty");
                Console.WriteLine($"2. Dodaj nowy rekord o id : {nextId} ");
                Console.WriteLine("3. Usun rekordy z id >= 81");
                Console.WriteLine("4. Modyfikuj podukt o wybranym id");
                Console.WriteLine("5. Exit");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
