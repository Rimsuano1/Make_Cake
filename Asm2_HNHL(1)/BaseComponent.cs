using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2_HNHL_1_
{
   class BaseComponent : Component
    {
        public override void MakeCake()
        {
            Console.WriteLine("*********************************Processing*********************************");
            Console.WriteLine("The cake base is completed. The cake base is waiting to be completed \n");
        }

    }
}
