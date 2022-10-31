using Heranca_Interface.Model.Enums;

namespace Heranca_Interface.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
