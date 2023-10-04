using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppFacadePattern.Model
{
    internal class ItalianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Italian Menu:");
            Console.WriteLine("1. Pizza ");
            Console.WriteLine("2. Pasta ");
            
        }
    }
}

