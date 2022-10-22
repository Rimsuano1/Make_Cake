using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2_HNHL_1_
{
    class CoverWithCream : AbstractDecorator
    {
        public override void MakeCake()
        {
            base.MakeCake();
            Console.WriteLine("*********************************Processing*********************************");
            Console.WriteLine("***Use sugar and eggs to coat the cake ***");
            CoverCream();
        }
        private void CoverCream()
        {
            Console.WriteLine("The Cake is covered with cream.\n");
        }
    }
}
