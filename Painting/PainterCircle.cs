using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Painting
{
    class PainterCircle : IPainter
    {
        Figure _figure = new Figure();

        public PainterCircle()
        {
            this.ResetFigure();
        }

        private void ResetFigure()
        {
            _figure = new Figure();
        }

        public void DrawFigure()
        {
            Console.WriteLine("Draw Circle");
        }

        public void FillFigure()
        {
            Console.WriteLine("Fill Circle");
        }

        public List<Point> MathPoint(Point point1, Point point2)
        {
            Console.WriteLine("Math all points for Circle");

            _figure.Add(point1);
            _figure.Add(point2);
            List<Point> listPoints = _figure.ListPoints();

            ResetFigure();

            return listPoints;
        }
    }
}
