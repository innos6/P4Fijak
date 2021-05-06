using System;


namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyContext();
            context.Database.EnsureCreated();

            context.MyUsers.Add(new MyUser { Name = "Snake", RegistrationDate = new DateTime(2020, 10, 25) } ) ;
            context.SaveChanges();
        }
    }
}
//Data Source = ASUS\ASUS; Initial Catalog = ZNorthwind; Integrated Security = True