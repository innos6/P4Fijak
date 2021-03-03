using System;
using System.Data.SqlClient;
using System.Globalization;

namespace Zadanie1
{
    

    class Program 
    {
        static void menu(int i)
        {
            Console.WriteLine("1. Polacz z DB ZNorthwind");
            Console.WriteLine("2. Rozlacz DB");
            Console.WriteLine("3. Wyswietl tabele Produkty");
            Console.WriteLine($"4. Dodaj nowy rekord o id : {i+1} ");
            Console.WriteLine("5. Usun rekordy z id >= 81");
            Console.WriteLine("6. Modyfikuj podukt o wybranym id");
            Console.WriteLine("7. Exit");
        }

        static void connect(SqlConnection connection,ref int i)
        {
            try
            {
                connection.Open();
                Console.WriteLine("Połączenie otwarte...");
                using (var command = new SqlCommand("SELECT MAX(IDproduktu) FROM mg.Produkty", connection))
                {
                    var lastId = command.ExecuteScalar();
                    int.TryParse(lastId.ToString(), out i);
                    
                }   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void disconnect(SqlConnection connection)
        {
            try
            {
                connection.Close();
                Console.WriteLine("Połączenie zamkniete.");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        static void create(SqlConnection connection, ref int id)
        {

            try
            {

                Console.Write("Podaj nazwe produktu : ");
                var nazwa = Console.ReadLine();
                Console.WriteLine("Podaj cene produktu (decimal): ");
                string cenaIN = Console.ReadLine();
                decimal cenaOut = 0;
                try
                {
                    decimal.TryParse(cenaIN, out cenaOut);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Podaj ilość produktu : ");
                var iloscIn = Console.ReadLine();
                int iloscOut = 0;
                int.TryParse(iloscIn, out iloscOut);

                string querry = $"INSERT INTO mg.Produkty ([IDproduktu], [NazwaProduktu], [CenaJednostkowa], [IlośćJednostkowa], [Wycofany])" +
                                 $"VALUES ('{id + 1}', '{nazwa}', '{cenaOut}', '{iloscOut}', '0')";
                using var command = new SqlCommand(querry, connection);
                command.ExecuteNonQuery();
                id++;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        static void delete(SqlConnection connection, ref int id)
        {
            try
            {
                var querry = ("DELETE FROM mg.Produkty WHERE IDproduktu > 80");
                using var command = new SqlCommand(querry, connection);
                command.ExecuteNonQuery();
                using (var command2 = new SqlCommand("SELECT MAX(IDproduktu) FROM mg.Produkty", connection))
                {
                    var lastId = command2.ExecuteScalar();
                    int.TryParse(lastId.ToString(), out id);
                }
                Console.WriteLine("Usunięto rekordy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void read(SqlConnection connection)
        {
            try
            {
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
        }

        static void update(SqlConnection connection)
        {
            Console.Write("Produkt o którym id chcesz zmienić? : ");
            var idIn = Console.ReadLine();
            int idOut = 0;
            int.TryParse(idIn, out idOut);
            Console.WriteLine("Podaj nową nazwę : ");
            var nazwa = Console.ReadLine();
            Console.WriteLine("Podaj nową cenę : ");
            var cenaIn = Console.ReadLine();
            
            decimal cenaOut = 0;
            decimal.TryParse(cenaIn, out cenaOut);
            Console.WriteLine("Podaj nową ilość : ");
            var IloscIn = Console.ReadLine();
            int iloscOut = 0;
            int.TryParse(IloscIn, out iloscOut);

            var querry = $"UPDATE mg.Produkty SET NazwaProduktu = '{nazwa}', CenaJednostkowa = {cenaOut}, IlośćJednostkowa = {iloscOut} " +
                         $"WHERE IDproduktu = {idOut}";
            var command = new SqlCommand(querry, connection);
            command.ExecuteNonQuery();
        }
    


    static void Main(string[] args)
        {
            using var connection = new SqlConnection("Server = ASUS-PC; Database = ZNorthwind; Integrated Security=true;");
            int lastId = 0;
            var a = "0";
            do
            {
                menu(lastId);
                a = Console.ReadLine();
                Console.Clear();
                switch (a)
                {
                    case "1":
                            {
                                connect(connection, ref lastId);
                                break;
                            } 
                    case "2": disconnect(connection); break;
                    case "3": read(connection); break;
                    case "4":
                            {
                                create(connection,ref lastId);
                                break;
                            }
                    case "5":
                            {
                                delete(connection, ref lastId);
                                break;
                            }
                    case "6": update(connection); break;
                    case "7": break;
                    default: break;
                }
            } while (a != "7");
        }
    }
}
