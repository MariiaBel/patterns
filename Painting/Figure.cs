using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Painting
{
    class Figure
    {
        List<Point> _points = new List<Point>();

        public void Add(Point point)
        {
            this._points.Add(point);
        }

        public List<Point> ListPoints()
        {
            return this._points;
        }

        public void ShowAllPoint()
        {
            foreach (var item in this._points)
            {
                Console.WriteLine("X: " + item.X + " Y: " + item.Y + "/n");
            }           
        }
    }
}
