using Shape_Drawing_System.Interfaces;

namespace Shape_Drawing_System.Services
{
    internal class Triangle : IShape, IDrawable, IRenderable
    {
        public void DrawShape()
        {
            Console.WriteLine("Drawing Triangle .. ");
        }

        public void MoveTo(int x, int y)
        {
            Console.WriteLine("Moving Triangle to X = " + x + ", Y = " + y);

        }

        public void RenderWith(CanvasRenderer renderer)
        {
            renderer.RenderDrawable(this);
        }
    }
}
