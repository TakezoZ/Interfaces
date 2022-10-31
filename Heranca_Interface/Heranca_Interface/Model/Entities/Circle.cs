using System.Globalization;

namespace Heranca_Interface.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Circle color = {Color} \nRadius = {Radius.ToString("F2",CultureInfo.InvariantCulture)}" +
                   $" \nArea = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
