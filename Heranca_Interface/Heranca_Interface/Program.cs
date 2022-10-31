using Heranca_Interface.Model.Entities;
using Heranca_Interface.Model.Enums;

namespace Heranca_interface
{
    class Program
    {
        static void Main(string[] Args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine(s2);
        }
    }
}