using Shape_Drawing_System.Models;

namespace Shape_Drawing_System.Interfaces
{
    internal interface IShapeFactory
    {
        void RegisterNewShape(Shape shape, Func<IShape> func);

        IShape GetShape(Shape shape);

    }
}
