using Shape_Drawing_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Drawing_System.Services
{
    internal class Circle : IShape, IDrawable, IRenderable
    {
        public void DrawShape()
        {
            Console.WriteLine("Drawing Circle .. ");
        }

        public void MoveTo(int x, int y)
        {
            Console.WriteLine("Moving Circle to X = " + x + ", Y = " + y);

        }

        public void RenderWith(CanvasRenderer renderer)
        {
            renderer.RenderDrawable(this);
        }
    }
}
