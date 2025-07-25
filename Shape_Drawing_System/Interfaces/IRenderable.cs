using Shape_Drawing_System.Services;

namespace Shape_Drawing_System.Interfaces
{
    internal interface IRenderable
    {
        void RenderWith(CanvasRenderer renderer);
    }
}
