using System;
using System.Data.SqlClient;

namespace Zadanie1
{
    public static class CRUDMenu
    {
        public static void create(SqlConnection connection)
        {
            try
            {
                Console.Write("Podaj nazwe produktu : ");
                var nazwa = Console.ReadLine();
                Console.WriteLine("Podaj cene produktu (X.XX): ");
                var cena = Console.ReadLine();
                Console.WriteLine("Podaj ilość produktu : ");
                var ilosc = Console.ReadLine();
                connection.Open();
                string querry =  $"DECLARE @lastId INT =  (SELECT MAX(Produkty.IDproduktu) FROM mg.Produkty)+1" +
                                 $"DECLARE @nazwa NVARCHAR(20)='{nazwa}'" +
                                 $"DECLARE @cena MONEY={cena}" +
                                 $"DECLARE @ilosc INT={ilosc}" +
                                 $"INSERT INTO mg.Produkty ([IDproduktu], [NazwaProduktu], [CenaJednostkowa], [IlośćJednostkowa], [Wycofany])" +
                                 $"VALUES (@lastId, @nazwa , @cena, @ilosc, 0)";
                using var command = new SqlCommand(querry, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static void read(SqlConnection connection)
        {
            try
            {
                connection.Open();
                using var command = new SqlCommand("Select * From mg.Produkty", connection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + " ");
                    }
                    Console.WriteLine();
                }
                connection.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static void delete(SqlConnection connection)
        {
            try
            {
                connection.Open();
                var querry = ("DELETE FROM mg.Produkty WHERE IDproduktu > 80");
                using var command = new SqlCommand(querry, connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Usunięto rekordy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void update(SqlConnection connection)
        {
            try
            {
                Console.Write("Produkt o którym id chcesz zmienić? : ");
                var id = Console.ReadLine();
                Console.WriteLine("Podaj nową nazwę : ");
                var nazwa = Console.ReadLine();
                Console.WriteLine("Podaj nową cenę : ");
                var cena = Console.ReadLine();
                Console.WriteLine("Podaj nową ilość : ");
                var ilosc = Console.ReadLine();
                connection.Open();
                var querry = $"DECLARE @id INT={id}" +
                             $"DECLARE @nazwa NVARCHAR(20)='{nazwa}'" +
                             $"DECLARE @cena MONEY={cena}" +
                             $"DECLARE @ilosc INT={ilosc}" +
                             $"UPDATE mg.Produkty SET NazwaProduktu = @nazwa, CenaJednostkowa = @cena, IlośćJednostkowa = @ilosc " +
                             $"WHERE IDproduktu = @id";
                var command = new SqlCommand(querry, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
