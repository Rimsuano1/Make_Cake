using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm2_HNHL_1_
{
     class Application
    {

        public void Choice()
        {
            List<BaseComponent> Cakes = new List<BaseComponent>();
            List<AddFloorCake> CakesAdd = new List<AddFloorCake>();
            List<CoverWithCream> CakeCv = new List<CoverWithCream>();
            List<ColorForCake> CakesColor = new List<ColorForCake>();
            int i = 0;
            int userChoice = 0;
            do
            {
                userChoice = Menu.MainMenu();
                switch (userChoice)
                {
                    case 1:
                        Factory.CreateCake(Cakes);
                        break;
                    case 2:
                        Factory.Addlayer(Cakes[i], CakesAdd);
                        break;
                    case 3:
                        Factory.CoverCake(CakesAdd[i], CakeCv);
                        break;
                    case 4:
                        Factory.ColoringCake(CakeCv[i], CakesColor);
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input, please input from 0 to 4");
                        break;
                }

            } while (userChoice != 0);
        }
    }
}
