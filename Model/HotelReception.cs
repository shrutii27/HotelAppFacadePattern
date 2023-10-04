using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppFacadePattern.Model
{
    internal class HotelReception
    {
        public void GetIndianMenu()
        {
            IHotel indHotel = new IndianHotel();
            IMenu menu = indHotel.GetMenu();
            menu.DisplayMenu();
        }

        public void GetItalianMenu()
        {
            IHotel itaHotel = new ItalianHotel();
            IMenu menu = itaHotel.GetMenu();
            menu.DisplayMenu();
        }

        public void GetChineseMenu()
        {
            
        }
    }
}
