using Crud_Home.Models;
using Crud_Home.Services;

namespace Crud_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void FrontEnd()
        {
            var homeService = new HomeService();

            while (true)
            {
                Console.WriteLine("1. Add Home");
                Console.WriteLine("2. Get Home By Id");
                Console.WriteLine("3. Delete Home");
                Console.WriteLine("4. Update Home");
                Console.WriteLine("5. Get All Homes");
                Console.WriteLine("6. Get Homes By Price");
                Console.WriteLine("7. Get Home By Floor");
                Console.WriteLine("8. Buy Homy By Id");

                var option = Console.ReadLine();

                if (option == "1")
                {
                    var home = new Home();

                    Console.Write("Enter Location");
                    home.Location = Console.ReadLine();
                    Console.Write("Enter rooms");
                    string rooms = Console.ReadLine();
                    home.Rooms.Add(rooms);
                    Console.Write("Enter Price");
                    home.Price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Floor");
                    home.Floor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Quantity");
                    home.Quantity = int.Parse(Console.ReadLine());

                    homeService.AddHome(home);
                }
            }
        }
    }
}
