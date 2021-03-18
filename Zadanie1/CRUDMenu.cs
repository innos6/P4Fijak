using System;
using System.Data.SqlClient;

namespace Zadanie1
{
    public static class CRUDMenu
    {
        private static SqlConnection connection = new SqlConnection(@"Server = ASUS\ASUS; Database = ZNorthwind; Integrated Security=true;");

        public static void create()
        {
            try
            {
                Console.Write("Podaj nazwe produktu : ");
                var nazwa = new SqlParameter("nazwa", System.Data.SqlDbType.VarChar);  
                nazwa.Value = Console.ReadLine();
                Console.WriteLine("Podaj cene produktu (X,XX): ");
                var cena = new SqlParameter("cena", System.Data.SqlDbType.Money);
                cena.Value = Console.ReadLine();
                Console.WriteLine("Podaj ilość produktu : ");
                var ilosc = new SqlParameter("ilosc", System.Data.SqlDbType.Int);
                ilosc.Value = Console.ReadLine();

                string querry =  $"DECLARE @lastId INT =  (SELECT MAX(Produkty.IDproduktu) FROM mg.Produkty)+1" +
                                 $"INSERT INTO mg.Produkty ([IDproduktu], [NazwaProduktu], [CenaJednostkowa], [IlośćJednostkowa], [Wycofany])" +
                                 $"VALUES (@lastId, @nazwa , @cena, @ilosc, 0)";
                using var command = new SqlCommand(querry, connection);
                command.Parameters.Add(nazwa);
                command.Parameters.Add(cena);
                command.Parameters.Add(ilosc);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void read()
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void delete()
        {
            try
            {
                connection.Open();
                var querry = ("DELETE FROM mg.Produkty WHERE IDproduktu > 80");
                using var command = new SqlCommand(querry, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Usunięto rekordy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void update()
        {
            try
            {
                Console.Write("Produkt o którym id chcesz zmienić? : ");
                var id = new SqlParameter("@id", System.Data.SqlDbType.Int);
                id.Value = Console.ReadLine();
                Console.WriteLine("Podaj nową nazwę : ");
                var nazwa = new SqlParameter("@nazwa", System.Data.SqlDbType.VarChar);
                nazwa.Value = Console.ReadLine();
                Console.WriteLine("Podaj nową cenę (X,XX) : ");
                var cena = new SqlParameter("@cena", System.Data.SqlDbType.Money);
                cena.Value = Console.ReadLine();
                Console.WriteLine("Podaj nową ilość : ");
                var ilosc = new SqlParameter("@ilosc", System.Data.SqlDbType.Int);
                ilosc.Value = Console.ReadLine();
                connection.Open();
                var querry = $"UPDATE mg.Produkty SET NazwaProduktu = @nazwa, CenaJednostkowa = @cena, IlośćJednostkowa = @ilosc " +
                             $"WHERE IDproduktu = @id";
                var command = new SqlCommand(querry, connection);
                command.Parameters.Add(id);
                command.Parameters.Add(nazwa);
                command.Parameters.Add(cena);
                command.Parameters.Add(ilosc);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
