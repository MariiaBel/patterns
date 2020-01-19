using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Painting
{
    class PainterLine : IPainter
    {
        Figure _figure = new Figure();

        public PainterLine()
        {
            this.ResetFigure();
        }

        private void ResetFigure()
        {
            _figure = new Figure();
        }

        public void DrawFigure()
        {
            Console.WriteLine("Draw Line");
        }

        public void FillFigure()
        {
        }

        public List<Point> MathPoint(Point point1, Point point2)
        {
            Console.WriteLine("Math all points for Line");

            _figure.Add(point1);
            _figure.Add(point2);
            List<Point> listPoints = _figure.ListPoints();

            ResetFigure();

            return listPoints;
        }
    }
}
