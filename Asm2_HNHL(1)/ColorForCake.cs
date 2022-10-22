using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2_HNHL_1_
{
   class ColorForCake : CoverWithCream
    {
        public override void MakeCake()
        {
            base.MakeCake();
            Console.WriteLine("*********************Processing*********************");
            Console.WriteLine("***The color will be mixed and covered with cake***");
           
        }
        private void ColorCake()
        {
            Console.WriteLine("The cake has been coated with your favorite color.");
            Console.WriteLine("********************Complete your cake**************\n \n");
        }
    }
}
