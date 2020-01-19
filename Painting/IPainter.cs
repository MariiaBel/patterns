using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Painting
{
    interface IPainter
    {
        List<Point> MathPoint(Point point1, Point point2);
        void DrawFigure();
        void FillFigure();
    }
}
