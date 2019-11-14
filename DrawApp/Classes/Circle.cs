using Assignment_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Circle : Shape
    {
        location location = new location();
        int radius; 

        public Circle() : base()
        {

        }
        public Circle(Color colour, int x, int y, int radius) : base(x, y)
        {
            location.x = x;
            location.y = y;
            this.radius = radius;
        }


        public override void set(params int[] list)
        {
            //base.set(list[0]/* x */, list[1] /* y */);
            location.x = list[0];
            location.y = list[1];
            this.radius = list[2] /* radius */;

        }

        public override void draw(Graphics g)
        {

            Pen p = new Pen(Color.Black, 2);
            g.DrawEllipse(p, location.x, location.y, radius * 2, radius * 2);

        }
    }
}
