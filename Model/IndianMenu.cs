using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppFacadePattern.Model
{
    internal class IndianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Indian Menu:");
            Console.WriteLine("1. Chaat");
            Console.WriteLine("2. Biryani");

        }
    }
}
