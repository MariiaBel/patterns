using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Painting
{
    class ArtDirector
    {
        IPainter _painter;
        Point FirstPoint { set; get; }
        Point SecondPoint { set; get; }

        public IPainter Painter
        {
            set { _painter = value; }
        }


        public void SetPints(Point point1, Point point2)
        {
            this.FirstPoint = point1;
            this.SecondPoint = point2;
        }
        public void PaintFigureConture()
        {
            _painter.MathPoint(FirstPoint, SecondPoint);
            _painter.DrawFigure();
        }
        public void PaintFigureFill()
        {
            _painter.MathPoint(FirstPoint, SecondPoint);
            _painter.DrawFigure();
            _painter.FillFigure();
        }
    }
}
