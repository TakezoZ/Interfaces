using System.Globalization;

namespace Heranca_Interface.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Rectangle color = {Color}\n" +
                   $"Width = {Width.ToString("F2",CultureInfo.InvariantCulture)}\n" +
                   $"Height = {Height.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
