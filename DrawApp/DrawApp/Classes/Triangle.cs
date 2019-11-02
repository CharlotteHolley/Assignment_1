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
        Point[] TriPoints = new Point[]
        {
            new Point { X = 0, Y = 0},
            new Point { X = 0, Y = 0},
            new Point { X = 0, Y = 0}
        };

        location location = new location();

        public Triangle() : base()
        {
            
        }
        public Triangle(int x, int y, int x1, int y1, int x2, int y2) : base(x, y)
        {
            TriPoints[0].X = x;
            TriPoints[0].Y = y;

            TriPoints[1].X = x1;
            TriPoints[1].Y = y1;

            TriPoints[2].X = x2;
            TriPoints[2].Y = y2;

        }

        public override void set(params int[] list)
        {
            base.set(list[0] /* x */, list[1] /* y */);
            base.set(list[2] /* x */, list[3] /* y */);
            base.set(list[4] /* x */, list[5] /* y */);
        }

        public override void draw(Graphics g)
        {

            Pen pen = new Pen(Color.Black, 2);
            g.DrawPolygon(pen, TriPoints);
        }
    }
}
}
