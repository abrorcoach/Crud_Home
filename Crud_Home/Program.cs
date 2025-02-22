using Crud_Home.Models;
using Crud_Home.Services;

namespace Crud_Home;

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
            Console.WriteLine("7. Get Homes By Floor");
            Console.WriteLine("8. Buy Home By Id");

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
            else if (option == "2")
            {
                Console.WriteLine("Enter Id");
                var id = Guid.Parse(Console.ReadLine());

                var home = homeService.GetById(id);

                string info = $"Id {home.Id}, Location {home.Location}, Rooms {home.Rooms} " +
                    $"Price {home.Price}, Floor {home.Floor}, Quantity {home.Quantity}";
                Console.WriteLine(info);

            }
            else if (option == "3")
            {
                Console.WriteLine("Enter id to delete: ");
                var id = Guid.Parse(Console.ReadLine());

                var res = homeService.DeleteHome(id);
                Console.WriteLine(res);
            }
            else if (option == "4")
            {

            }
            else if (option == "5")
            {
                var homes = homeService.GetAllHomes();

                foreach (var home in homes)
                {
                    string info = $"Id {home.Id}, Location {home.Location}, Rooms {home.Rooms} " +
                    $"Price {home.Price}, Floor {home.Floor}, Quantity {home.Quantity}";
                    Console.WriteLine(info);
                }
            }
            else if (option == "6")
            {
                Console.Write("Enter min price: ");
                double minPrice = double.Parse(Console.ReadLine());
                Console.Write("Enter max price: ");
                double maxPrice = double.Parse(Console.ReadLine());

                var homes = homeService.GetHomesByPrice(minPrice, maxPrice);

                foreach (var home in homes)
                {
                    string info = $"Id {home.Id}, Location {home.Location}, Rooms {home.Rooms} " +
                    $"Price {home.Price}, Floor {home.Floor}, Quantity {home.Quantity}";
                    Console.WriteLine(info);
                }
            }
            else if (option == "7")
            {
                Console.Write("Enter Floor: ");
                int floor = int.Parse(Console.ReadLine());

                var homes = homeService.GetHomesByFloor(floor);

                foreach (var home in homes)
                {
                    string info = $"Id {home.Id}, Location {home.Location}, Rooms {home.Rooms} " +
                    $"Price {home.Price}, Floor {home.Floor}, Quantity {home.Quantity}";
                    Console.WriteLine(info);
                }

            }
        }
    }

}