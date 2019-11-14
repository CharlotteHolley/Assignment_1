using Assignment_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Triangle : Shape
    {
        location location = new location();

        Point[] TriPoints = new Point[]
        {
            new Point { X = 0, Y = 0},
            new Point { X = 0, Y = 0},
            new Point { X = 0, Y = 0}
        };

        public Triangle() : base()
        {
        }
        public Triangle(int x, int y, int x1, int y1, int x2, int y2) : base(x, y)
        {
            TriPoints[0].X = location.x;
            TriPoints[0].Y = location.y;

            TriPoints[1].X = x1;
            TriPoints[1].Y = y1;

            TriPoints[2].X = x2;
            TriPoints[2].Y = y2;

        }

        public override void set(params int[] list)
        {

            TriPoints[0].X = list[0];
            TriPoints[0].Y = list[1];
            TriPoints[1].X = list[2];
            TriPoints[1].Y = list[3];
            TriPoints[2].X = list[4];
            TriPoints[2].Y = list[5];

        }

        public override void draw(Graphics g)
        {

            Pen pen = new Pen(Color.Black, 2);

            g.DrawPolygon(pen, TriPoints);
        }
    }
}
