using Shape_Drawing_System.Interfaces;


namespace Shape_Drawing_System.Services
{
    internal class CanvasRenderer
    {
        public void Render(IRenderable item) => item.RenderWith(this);

        public void RenderDrawable(IDrawable d) => d.DrawShape();
        public void RenderTextable(ITextable t) => t.RenderText();
    }

}
