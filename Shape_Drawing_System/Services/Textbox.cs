using Shape_Drawing_System.Interfaces;

namespace Shape_Drawing_System.Services
{
    internal class Textbox : ITextable, IShape, IRenderable
    {
        public void MoveTo(int x, int y)
        {
            Console.WriteLine("Moving Textbox to X = " + x + ", Y = " + y);
        }

        public void RenderText()
        {
            Console.WriteLine("Render Text of Textbox .. ");

        }

        public void RenderWith(CanvasRenderer renderer)
        {
            renderer.RenderTextable(this);
        }
    }
}
