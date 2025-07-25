using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shape_Drawing_System.Interfaces;
using Shape_Drawing_System.Models;
using Shape_Drawing_System.Services;
using System.Buffers;



var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<IShapeFactory, ShapeFactory>();
    })
    .Build();


var shapeFactory = host.Services.GetRequiredService<IShapeFactory>();

var cavanceRendable = new CanvasRenderer();

var allSahpes = Enum.GetValues(typeof(Shape)).Cast<Shape>().ToList();

// register new value 

shapeFactory.RegisterNewShape(Shape.Textbox, () => new Textbox());

foreach (var item in allSahpes)
{
    var shape = shapeFactory.GetShape(item);

    shape.MoveTo(10, 15);

    var renderSahpe = shape as IRenderable;

    if (renderSahpe != null)
    {
        cavanceRendable.Render(renderSahpe);
    }
    else
    {
        Console.WriteLine("This shape " + item + " does't have draw ot renderText function");
    }
}




