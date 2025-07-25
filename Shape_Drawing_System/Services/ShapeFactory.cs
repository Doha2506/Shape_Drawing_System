using Shape_Drawing_System.Interfaces;
using Shape_Drawing_System.Models;

namespace Shape_Drawing_System.Services
{
    internal class ShapeFactory : IShapeFactory
    {
        private readonly Dictionary<Shape, Func<IShape>> _shapes;
        public ShapeFactory()
        {
            _shapes = new Dictionary<Shape, Func<IShape>>();

            RegisterDefualtShapes();
        }

        private void RegisterDefualtShapes()
        {
            _shapes.Add(Shape.Circle , () => new Circle());
            _shapes.Add(Shape.Rectangle , () => new Rectangle());
            _shapes.Add(Shape.Triangle , () => new Triangle());
        }


        public void RegisterNewShape(Shape shape, Func<IShape> func)
        {
            if (_shapes.ContainsKey(shape)) 
            { 
                throw new ArgumentException("There is already shape " + shape);
            }
            _shapes.Add(shape, func);
        }

        public IShape GetShape(Shape shape) 
        {
            if (!_shapes.ContainsKey(shape))
            {
                throw new ArgumentException("There is no shape " + shape);
            }

            return _shapes[shape]();
        }
       
    }
}
