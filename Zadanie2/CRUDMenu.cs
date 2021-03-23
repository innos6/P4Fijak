using System;
using System.Data.SqlClient;
using Dapper;

namespace Zadanie2
{
    public static class CRUDMenu
    {
        private static SqlConnection connection = new SqlConnection(@"Server = ASUS\ASUS; Database = ZNorthwind; Integrated Security=true;");
     
        public static void create()
        {

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                Console.Write("Podaj nazwe produktu : ");
                parameters.Add("@nazwa", Console.ReadLine(), System.Data.DbType.String, System.Data.ParameterDirection.Input);
                Console.WriteLine("Podaj cene produktu (X,XX): ");
                parameters.Add("@cena", Console.ReadLine(), System.Data.DbType.Currency, System.Data.ParameterDirection.Input);
                Console.WriteLine("Podaj ilość produktu : ");
                parameters.Add("@ilosc", Console.ReadLine(), System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
                string querry = $"DECLARE @lastId INT =  (SELECT MAX(Produkty.IDproduktu) FROM mg.Produkty)+1" +
                                 $"INSERT INTO mg.Produkty ([IDproduktu], [NazwaProduktu], [CenaJednostkowa], [IlośćJednostkowa], [Wycofany])" +
                                 $"VALUES (@lastId, @nazwa , @cena, @ilosc, 0)";
                connection.Execute(querry, parameters);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static void read()
        {
            try
            {
                using var reader = connection.ExecuteReader("Select * From mg.Produkty");
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
        }

        public static void delete()
        {
            try
            {
                var querry = ("DELETE FROM mg.Produkty WHERE IDproduktu > 80");
                connection.Execute(querry);
                Console.WriteLine("Usunięto rekordy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void update()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                Console.Write("Produkt o którym id chcesz zmienić? : ");
                parameters.Add("@id", Console.ReadLine(), System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
                Console.Write("Podaj nazwe produktu : ");
                parameters.Add("@nazwa", Console.ReadLine(), System.Data.DbType.String, System.Data.ParameterDirection.Input);
                Console.WriteLine("Podaj cene produktu (X,XX): ");
                parameters.Add("@cena", Console.ReadLine(), System.Data.DbType.Currency, System.Data.ParameterDirection.Input);
                Console.WriteLine("Podaj ilość produktu : ");
                parameters.Add("@ilosc", Console.ReadLine(), System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
                var querry = $"UPDATE mg.Produkty SET NazwaProduktu = @nazwa, CenaJednostkowa = @cena, IlośćJednostkowa = @ilosc " +
                             $"WHERE IDproduktu = @id";
                connection.Execute(querry, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
