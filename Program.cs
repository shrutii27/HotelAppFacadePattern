using HotelAppFacadePattern.Model;

namespace HotelAppFacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelReception reception = new HotelReception();

            Console.WriteLine("Getting Indian Menu-");
            reception.GetIndianMenu();

            Console.WriteLine("\nGetting Italian Menu-");
            reception.GetItalianMenu();


            Console.ReadLine();
        }
    }
}