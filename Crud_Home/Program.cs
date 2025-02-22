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
            }
        }
    }
}
