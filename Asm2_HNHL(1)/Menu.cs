using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2_HNHL_1_
{
    class Menu
    {
        public static int MainMenu()
        {
            int choice;
            Console.WriteLine("              ====================Student and Grade====================");
            Console.WriteLine("              Choose one of the following options:                     ");
            Console.WriteLine("              Press 1 : Create base cake                               ");
            Console.WriteLine("              Press 2: Add a layer to the cake                         ");
            Console.WriteLine("              Press 3: Cover the cake with cream                       ");
            Console.WriteLine("              Press 4: Coloring the cake                               ");
            Console.WriteLine("              Press 0: Exit                                            ");
            Console.WriteLine("              =========================================================");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
