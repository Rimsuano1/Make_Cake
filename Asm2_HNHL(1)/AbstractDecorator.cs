using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2_HNHL_1_
{
   class AbstractDecorator : Component
    {
        protected Component decor1;
        public void SetTheComponent(Component d)
        {
            decor1 = d;
        }
        public override void MakeCake()
        {
            if(decor1 != null)
            {
                decor1.MakeCake();
            }
        }
    }
}
