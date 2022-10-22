using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using Asm2_HNHL_1_;
using Application = Asm2_HNHL_1_.Application;

class Factory : BaseComponent
{
    public static void CreateCake(List<BaseComponent> Cakes)
    {
        BaseComponent cake1 = new BaseComponent();
       
        Cakes.Add(cake1);
        cake1.MakeCake();
    }

    public static void Addlayer(BaseComponent cake1, List<AddFloorCake> CakesAdd)
    {
        AddFloorCake cakeAdd1Floor = new AddFloorCake();
        cakeAdd1Floor.SetTheComponent(cake1);
        cakeAdd1Floor.MakeCake();
        CakesAdd.Add(cakeAdd1Floor);
    }

    public static void CoverCake(AddFloorCake cake2, List<CoverWithCream> CakesCv)
    {
        CoverWithCream cakeCoverCream = new CoverWithCream();
        cakeCoverCream.SetTheComponent(cake2);
        cakeCoverCream.MakeCake();
        CakesCv.Add(cakeCoverCream);
    }

    public static void ColoringCake(CoverWithCream cake3, List<ColorForCake> CakesColor)
    {
        ColorForCake cakeColor = new ColorForCake();
        cakeColor.SetTheComponent(cake3);
        cakeColor.MakeCake();
        CakesColor.Add(cakeColor);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("***Create a birthday cake***");
        Application application = new Application();
        application.Choice();
    }

}

   