using System;
using System.Drawing;

namespace Painting
{
    class Program
    {
        static void Main(string[] args)
        {

            ArtDirector artDirctor = new ArtDirector();
            IPainter circle = new PainterCircle();
            IPainter polygon = new PainterPolygon();
            IPainter line = new PainterLine();

            artDirctor.Painter = line;
            artDirctor.SetPints(new Point(100, 100), new Point(200, 50));
            artDirctor.PaintFigureConture();

            Console.WriteLine(new string('-', 30));

            artDirctor.Painter = circle;
            artDirctor.SetPints(new Point(10, 100), new Point(20, 50));
            artDirctor.PaintFigureConture();

            Console.WriteLine(new string('-', 30));

            artDirctor.Painter = polygon;
            artDirctor.SetPints(new Point(140, 100), new Point(20, 10));
            artDirctor.PaintFigureFill();

            Console.ReadKey();
        }
    }
}
