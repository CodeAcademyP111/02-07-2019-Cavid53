using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hall p111 = new Hall("P111", 3500, 3, 6);
            p111.BuyTicket(0, 5, 3500);
            p111.BuyTicket(0, 5, 3600);

            Cinema VIP = new Cinema("VIP", "Mashtagha");
            VIP.AddHall(p111);

            //sealed class example

            Test test = new Test();
        }
    }

    sealed class Test
    {

    }

    class TryGetInhrTest : Test
    {

    }
}
