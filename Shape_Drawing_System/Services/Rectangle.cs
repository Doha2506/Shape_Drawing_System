using Shape_Drawing_System.Interfaces;

namespace Shape_Drawing_System.Services
{
    internal class Rectangle : IShape, IDrawable, IRenderable
    {
        public void DrawShape()
        {
            Console.WriteLine("Drawing Rectangele ..");
        }

        public void MoveTo(int x, int y)
        {
            Console.WriteLine("Moving Rectangele to X = " + x + ", Y = " + y);

        }

        public void RenderWith(CanvasRenderer renderer)
        {
            renderer.RenderDrawable(this);
        }
    }
}
