using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Asm2_HNHL_1_
{
     class AddFloorCake : AbstractDecorator
    {
        public override void MakeCake()
        {
            base.MakeCake();
            Console.WriteLine("*********************Processing*********************");
            Console.WriteLine("***User more flour to add layer to the cake***");
            AddFloor();

        }
        private void AddFloor()
        {
            Console.WriteLine("Cake has been added 1 layer. \n");
            }
        }
    }

